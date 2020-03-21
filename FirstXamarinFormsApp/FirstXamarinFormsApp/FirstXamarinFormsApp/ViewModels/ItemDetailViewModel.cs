using System;

using FirstXamarinFormsApp.Models;

namespace FirstXamarinFormsApp.ViewModels
{
   public class ItemDetailViewModel : BaseViewModel
   {
      public Item Item { get; set; }
      public ItemDetailViewModel(Item item = null)
      {
         Title = item?.Text;
         Item = item;
      }
   }
}
