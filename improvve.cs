using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP
{
    /// <summary>
    /// T��da pro implementaci funkce rotoru ve stroji Enigma
    /// </summary>
    class Rotor
    { 
        private readonly string _layout;
        private byte _offset;
        private Rotor _previous, _next;
        protected Label _lbl;
        private char _cIn = '\0', _notchPos;

        /// <summary>
        /// Konstruktor pro vytvo�en� nov�ho rotoru
        /// </summary>
        /// <param name="layout">Uspo��d�n� rotoru</param>
        /// <param name="notchPos">Poloha z��ezu rotoru</param>
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
        /// Vlastnost pro z�sk�n� rozlo�en� rotoru
        /// </summary>
        public string Layout => _layout;

        /// <summary>
        /// Vlastnost pro z�sk�n� nebo nastaven� dal��ho rotoru
        /// </summary>
        public Rotor Next
        {
            get => _next;
            set => _next = value;
        }

        /// <summary>
        /// Vlastnost pro z�sk�n� nebo nastaven� p�edchoz�ho rotoru
        /// </summary>
        public Rotor Previous
        {
            get => _previous;
            set => _previous = value;
        }

        /// <summary>
        /// Metoda pro z�sk�n� inverzn�ho znaku na dan� pozici
        /// </summary>
        /// <param name="ch">Znak, pro kter� se z�sk� inverzn� hodnota</param>
        /// <returns>Inverzn� znak</returns>
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
        /// Vlastnost pro z�sk�n� posunu rotoru
        /// </summary>
        public int Offset => _offset;

        /// <summary>
        /// Vlastnost pro z�sk�n� polohy z��ezu rotoru
        /// </summary>
        public char NotchPos => _notchPos;

        /// <summary>
        /// Metoda pro resetov�n� posunu rotoru
        /// </summary>
        public void ResetOffset()
        {
            _offset = 0;
        }

        /// <summary>
        /// Metoda pro kontrolu, zda m� rotor dal�� rotor
        /// <summary>
        public bool HasNext()
        {
            return _next != null;
        }

        /// <summary>
        /// Metoda pro kontrolu, zda m� rotor p�edchoz� rotor
        /// </summary>
        public bool HasPrevious()
        {
            return _previous != null;
        }

        /// <summary>
        /// Metoda pro p�esun rotoru do dal�� polohy
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
        /// Metoda pro p�esun rotoru do p�edchoz� polohy
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
        /// Metoda pro vlo�en� dat do rotoru
        /// </summary>
        /// <param name="s">�daje, kter� maj� b�t vlo�eny do rotoru</param>
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
        /// Metoda pro z�sk�n� dat z rotoru
        /// </summary>
        /// <returns>Data, kter� byla zpracov�na rotorem</returns>
        public char GetDataOut()
        {
            char c;
            if (_next != null)
            {
                c = _next.GetDataOut();
                c = GetInverseCharAt(c);
            }
            else
            { //pouze v p��pad� reflektoru
                c = _layout[(_cIn - 'A')];
                c = (char)(((c - 'A') + _previous._offset) % 26 + 'A');
            }

            return c;
        }

    }
}
