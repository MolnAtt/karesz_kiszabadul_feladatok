using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {

		string betöltendő_pálya = "palya13.txt";

		void TANÁR_ROBOTJAI()
		{
			new Robot("Karesz", 0, 0, 0, 0, 0, 21, 17, 1);
		}
		
    }
}