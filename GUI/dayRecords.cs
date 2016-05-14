using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELS.GUI
{
    public partial class dayRecords : Form
    {
        public dayRecords()
        {
            InitializeComponent();
        }

        public void fillFields(Users.Student student, string date) {
            string[] dates = date.Split('/');
 
            DateTime dt = new DateTime(Convert.ToInt32(dates[2]), Convert.ToInt32(dates[1]), Convert.ToInt32(dates[0]));

            if (!student.DayRecords.ContainsKey(dt))
            {
                return;
            }
            foreach (Records.Record record in student.DayRecords[dt]) {
                switch (record.GetType().ToString().Substring(12))
                {
                    case "Grade" :
                        rtxt_records.Text += ((Records.Grade)record).Subject + ": " + ((Records.Grade)record).GradeOfStudent;
                        break;
                    case "Note":
                        rtxt_records.Text += ((Records.Note)record).Subject + ": " + ((Records.Note)record).Note;
                        break;
                    case "Absence":
                        rtxt_records.Text += "Absence: " + ((Records.Absence)record).Subject;
                        break;
                    default:
                        break;
                }
                rtxt_records.Text += "\n";
            }

            
        }
    }
}
