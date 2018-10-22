﻿using System.Windows.Forms;

namespace KutuphaneData.Models
{
   public class Helper
    {
       public void SelectCmb(ComboBox cmb, int id)
       {
           foreach (object item in cmb.Items)
           {
               var listItem = item as ListItem;
               if (listItem!=null)
               {
                   if (listItem.Id==id)
                   {
                       cmb.SelectedItem = listItem;
                       break;
                   }
               }
           }
       }
    }
}
