using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SpkBIK
{
    class ItemsCB
    {
        public ItemsCB(string name, string id)
        {
            Name = name;
            ID = id;
        }

        public string Name { get; set; }
        public string ID { get; set; }
    }   

    class Directory
    {
        public List<ItemsCB> theList = new List<ItemsCB>();
        /// <summary>
        /// Получение данных для элементов ComboBox
        /// </summary>
        /// <param name="Command">SQL команда</param>
        ///  <param name="addAll">добавить в спсок значение : 0 - нет, 1 - все, 2 - нет данных</param>
        /// <returns></returns>
        public void DirectorySelect(string Command, int addAll)
        {
            try
            {                               
                WorkWithDBF wwd = new WorkWithDBF();
                wwd.CreateConnection(Command);
                wwd.ExecuteConnection();

                if(addAll == 1)
                    theList.Add(new ItemsCB("-- все --", "0"));
                else if (addAll == 2)
                    theList.Add(new ItemsCB("-- нет --", "0"));

                if (wwd.ds.Tables.Count >= 0)
                {
                    foreach (DataRow dr in wwd.ds.Tables[0].Rows)
                    {
                        theList.Add(new ItemsCB(dr[1].ToString(),dr[0].ToString()));
                    }
                    
                }
                else
                    MessageBox.Show("Ошибка! Нет данных для отображениия!", "Внимание");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка! Непредвиденная ошика " + error.Message, "Внимание");
            }
           
        }
    }
}
