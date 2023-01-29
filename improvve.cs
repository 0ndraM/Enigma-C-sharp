using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP
{
    /// <summary>
    /// Tøída pro implementaci funkce rotoru ve stroji Enigma
    /// </summary>
    class Rotor
    { 
        private readonly string _layout;
        private byte _offset;
        private Rotor _previous, _next;
        protected Label _lbl;
        private char _cIn = '\0', _notchPos;

        /// <summary>
        /// Konstruktor pro vytvoøení nového rotoru
        /// </summary>
        /// <param name="layout">Uspoøádání rotoru</param>
        /// <param name="notchPos">Poloha záøezu rotoru</param>
        public Rotor(string layout, char notchPos)
        {
            if (string.IsNullOrEmpty(layout))
            {
                throw new ArgumentException("Rotor layout cannot be null or empty", nameof(layout));
            }
            if (layout.Length != 26)
            {
                throw new ArgumentException("Rotor layout must be of 26 characters", nameof(layout));
            }
            _layout = layout;
            _notchPos = notchPos;
            _offset = 0;
            _lbl = lbl;
        }

        /// <summary>
        /// Vlastnost pro získání rozložení rotoru
        /// </summary>
        public string Layout => _layout;

        /// <summary>
        /// Vlastnost pro získání nebo nastavení dalšího rotoru
        /// </summary>
        public Rotor Next
        {
            get => _next;
            set => _next = value;
        }

        /// <summary>
        /// Vlastnost pro získání nebo nastavení pøedchozího rotoru
        /// </summary>
        public Rotor Previous
        {
            get => _previous;
            set => _previous = value;
        }

        /// <summary>
        /// Metoda pro získání inverzního znaku na dané pozici
        /// </summary>
        /// <param name="ch">Znak, pro který se získá inverzní hodnota</param>
        /// <returns>Inverzní znak</returns>
        public char GetInverseCharAt(char ch)
        {
            int pos = _layout.IndexOf(ch);

            if (_offset > pos)
            {
                pos = 26 - (_offset - pos);
            }
            else
            {
                pos -= _offset;
            }

            if (_previous != null)
            {
                pos = (pos + _previous.Offset) % 26;
            }

            return (char)('A' + pos);
        }

        /// <summary>
        /// Vlastnost pro získání posunu rotoru
        /// </summary>
        public int Offset => _offset;

        /// <summary>
        /// Vlastnost pro získání polohy záøezu rotoru
        /// </summary>
        public char NotchPos => _notchPos;

        /// <summary>
        /// Metoda pro resetování posunu rotoru
        /// </summary>
        public void ResetOffset()
        {
            _offset = 0;
        }

        /// <summary>
        /// Metoda pro kontrolu, zda má rotor další rotor
        /// <summary>
        public bool HasNext()
        {
            return _next != null;
        }

        /// <summary>
        /// Metoda pro kontrolu, zda má rotor pøedchozí rotor
        /// </summary>
        public bool HasPrevious()
        {
            return _previous != null;
        }

        /// <summary>
        /// Metoda pro pøesun rotoru do další polohy
        /// </summary>
        public void Move()
        {
            if (_next == null)
            {
                return;
            }
            _offset++;
            if (_offset == 26)
            {
                _offset = 0;
            }

            if (_next != null && (_offset + 'A') == (_notchPos % 26) + 'A')
            {
                _next.Move();
            }
        }

        /// <summary>
        /// Metoda pro pøesun rotoru do pøedchozí polohy
        /// </summary>
        public void MoveBack()
        {
            if (_offset == 0)
            {
                _offset = 26;
            }
            _offset--;
        }

        /// <summary>
        /// Metoda pro vložení dat do rotoru
        /// </summary>
        /// <param name="s">Údaje, které mají být vloženy do rotoru</param>
        public void PutDataIn(char s)
        {
            _cIn = s;
            char c = s;
            c = (char)(((c - 'A') + _offset) % 26 + 'A');

            if (_next != null)
            {
                c = _layout[(c - 'A')];
                c = (char)(((c - 'A') + (-_offset)) % 26 + 'A');
                _next.PutDataIn(c);
            }
        }

        /// <summary>
        /// Metoda pro získání dat z rotoru
        /// </summary>
        /// <returns>Data, která byla zpracována rotorem</returns>
        public char GetDataOut()
        {
            char c;
            if (_next != null)
            {
                c = _next.GetDataOut();
                c = GetInverseCharAt(c);
            }
            else
            { //pouze v pøípadì reflektoru
                c = _layout[(_cIn - 'A')];
                c = (char)(((c - 'A') + _previous._offset) % 26 + 'A');
            }

            return c;
        }

    }
}
