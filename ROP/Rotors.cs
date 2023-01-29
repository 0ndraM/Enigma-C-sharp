using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ROP
{
    class Rotor
    {
        /// <summary>
        /// Třída pro implementaci funkce rotoru ve stroji Enigma
        /// </summary>
        protected string layout;
        protected byte offset;
        protected Rotor previous, next;
        protected Label lbl;
        protected char cIn = '\0', notchPos;

        /// <summary>
        /// Konstruktor pro vytvoření nového rotoru
        /// </summary>
        /// <param name="layout">Uspořádání rotoru</param>
        /// <param name="notchPos">Poloha zářezu rotoru</param>
        public Rotor(string layout, Label lbl, char notchPos)
        {
            this.layout = layout;
            this.lbl = lbl;
            this.notchPos = notchPos;
            offset = 0;
        }

        /// <summary>
        /// Vlastnost pro získání rozložení rotoru
        /// </summary>
        public string Layout()
        {
            return layout;
        }

        /// <summary>
        /// Vlastnost pro získání nebo nastavení dalšího rotoru
        /// </summary>
        public void SetNext(Rotor next)
        {
            this.next = next;
        }

        /// <summary>
        /// Vlastnost pro získání nebo nastavení předchozího rotoru
        /// </summary>
        public void SetPrevious(Rotor previous)
        {
            this.previous = previous;
        }

        /// <summary>
        /// Metoda pro získání inverzního znaku na dané pozici
        /// </summary>
        /// <param name="ch">Znak, pro který se získá inverzní hodnota</param>
        /// <returns>Inverzní znak</returns>
        public char GetInverseCharAt(string ch)
        {
            int pos = layout.IndexOf(ch);

            if (offset > pos)
            {
                pos = 26 - (offset - pos);
            }
            else
            {
                pos -= offset;
            }

            if (previous != null)
            {
                pos = (pos + previous.GetOffset()) % 26;
            }

            return (char)('A' + pos);
        }

        /// <summary>
        /// Vlastnost pro získání posunu rotoru
        /// </summary>
        public int GetOffset()
        {
            return offset;
        }

        // <summary>
        /// Vlastnost pro získání polohy zářezu rotoru
        /// </summary>
        public char GetNotchPos()
        {
            return notchPos;
        }

        /// <summary>
        /// Metoda pro resetování posunu rotoru
        /// </summary>
        public void ResetOffset()
        {
            offset = 0;
        }

        /// <summary>
        /// Metoda pro kontrolu, zda má rotor další rotor
        /// <summary>
        public bool HasNext()
        {
            return next != null;
        }

        /// <summary>
        /// Metoda pro kontrolu, zda má rotor předchozí rotor
        /// </summary>
        public bool HasPrevious()
        {
            return previous != null;
        }

        /// <summary>
        /// Metoda pro přesun rotoru do další polohy
        /// </summary>
        public void Move()
        {
            if (next == null)
            {
                return;
            }
            offset++;
            if (offset == 26)
            {
                offset = 0;
            }

            if (next != null && (offset + 'A') == ((notchPos - 'A') % 26) + 66)
            {
                next.Move();
            }
            lbl.Text = "" + ((char)('A' + offset));
        }

        /// <summary>
        /// Metoda pro přesun rotoru do předchozí polohy
        /// </summary>
        public void MoveBack()
        {
            if (offset == 0)
            {
                offset = 26;
            }
            offset--;

            lbl.Text = "" + ((char)(65 + offset));
        }

        /// <summary>
        /// Metoda pro vložení dat do rotoru
        /// </summary>
        /// <param name="s">Údaje, které mají být vloženy do rotoru</param>
        public void PutDataIn(char s)
        {
            cIn = s;
            char c = s;
            c = (char)(((c - 'A') + offset) % 26 + 'A');

            if (next != null)
            {
                c = layout.Substring((c - 'A'), 1).ToCharArray()[0];
                if ((((c - 'A') + (-offset)) % 26 + 'A') >= 'A')
                {
                    c = (char)(((c - 'A') + (-offset)) % 26 + 'A');
                }
                else
                {
                    c = (char)(((c - 'A') + (26 + (-offset))) % 26 + 'A');
                }
                next.PutDataIn(c);

            }
        }

        /// <summary>
        /// Metoda pro získání dat z rotoru
        /// </summary>
        /// <returns>Data, která byla zpracována rotorem</returns>
        public char GetDataOut()
        {
            char c;
            if (next != null)
            {
                c = next.GetDataOut();
                c = GetInverseCharAt("" + c);
            }
            else
            { //pouze v případě reflektoru
                c = layout[(cIn - 'A')];
                c = (char)(((c - 'A') + previous.offset) % 26 + 'A');

            }
            return c;
        }
    }
}