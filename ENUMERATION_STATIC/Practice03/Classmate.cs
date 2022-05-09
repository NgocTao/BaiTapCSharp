using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice03
{
    internal class Classmate
    {
        private string _name = "";
        private string _position = "";
        public int _nameGroup;

        private static int _quantity;
        public static int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public static string NameTecher = "";
        public static string NameClass = "";

        public Classmate(string name, string poisition, int nameGroup)
        {
            _name = name;
            _position = poisition;
            _nameGroup = nameGroup;
            _quantity++;
        }

        public static void GetGroup(int num, List<Classmate> dsHs)
        {
            for (int i = 0; i < dsHs.Count; i++)
            {
                if (dsHs[i]._nameGroup.Equals(num))
                {
                    dsHs[i].ShowInfo();
                }
            }
        }
        public static void Find_student(string poi, List<Classmate> dsHs)
        {
            for (int i = 0; i < dsHs.Count; i++)
            {
                if (dsHs[i]._position.Equals(poi))
                {
                    dsHs[i].ShowInfo();
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", _name, _position, _nameGroup, NameClass, NameTecher);
        }
    }
}
