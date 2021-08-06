using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class ZNO
    {
        protected string subject;
        public string Subject
        {
            set
            {
                subject = value;
            }
            get { return subject; }
        }
        protected double points;
        public double Points
        {
            set
            {
                points = value;
            }
            get
            {
                return points;
            }
        }
        public ZNO(string subject, double points)
        {
            Subject = subject;
            Points = points;
        }
    }
}
