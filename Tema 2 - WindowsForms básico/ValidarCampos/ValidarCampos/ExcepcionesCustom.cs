using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarCampos
{
    class DNI_Exception: ApplicationException
    {
        string msg;
        public DNI_Exception(string msg)
        {
            this.msg = msg;
        }

        public string Msg
        {
            get
            {
                return this.msg;
            }
        }
    }

    class Email_Exception : ApplicationException
    {
        string msg;
        public Email_Exception(string msg)
        {
            this.msg = msg;
        }

        public string Msg
        {
            get
            {
                return this.msg;
            }
        }
    }

    class IBAN_Exception : ApplicationException
    {
        string msg;
        public IBAN_Exception(string msg)
        {
            this.msg = msg;
        }

        public string Msg
        {
            get
            {
                return this.msg;
            }
        }
    }

    class Matricula_Exception : ApplicationException
    {
        string msg;
        public Matricula_Exception(string msg)
        {
            this.msg = msg;
        }

        public string Msg
        {
            get
            {
                return this.msg;
            }
        }
    }
}
