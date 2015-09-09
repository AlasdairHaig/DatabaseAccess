using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseAccess
{
    public class Mitarbeiter
    {

        #region Variables

        private string m_sVorname;      //Vorname
        private string m_sName;         //Surname
        private string m_sStrasse;      //Straße
        private string m_sOrt;          //Ort
        private string m_nPostleitzahl; //Postleitzahl
        private string m_nHausnummer;   //Hausnummer

        #endregion

        #region Getter/Setter

        public string Vorname
        {
            get { return m_sVorname; }
            set { m_sVorname = value; }
        }

        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }

        public string Strasse
        {
            get { return m_sStrasse; }
            set { m_sStrasse = value; }
        }

        public string Ort
        {
            get { return m_sOrt; }
            set { m_sOrt = value; }
        }

        public string Postleitzahl
        {
            get { return m_nPostleitzahl; }
            set { m_nPostleitzahl = value; }
        }

        public string Hausnummer
        {
            get { return m_nHausnummer; }
            set { m_nHausnummer = value; }
        }

        #endregion

        #region Constructor

        public Mitarbeiter()
        {
            m_sVorname = "";
            m_sName = "";
            m_sStrasse = "";
            m_sOrt = "";
            m_nPostleitzahl = "";
            m_nHausnummer = "";
        }

        #endregion

        public string concatToString()
        {
            return (m_sName + ", " + m_sVorname + "\t" + m_nHausnummer + "\t" + m_sStrasse + "\t" + m_nPostleitzahl + "\t" + m_sOrt);
        }

    }
}
