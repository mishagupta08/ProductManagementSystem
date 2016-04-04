using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductManagementSystemData;
using System.Web.Mvc;

namespace ProductManagementSystem.Models
{
    public class HomeModel : tblUserMaster
    {

        public HomeModel()
        {
            UsersList = new List<HomeModel>();
            nagativeStockList = new List<NagativeStock>();
            userList = new List<SelectListItem>();
            statusList = new List<SelectListItem>();
        }
        public int StatusID { get; set; }
        public int ID { get; set; }
        public string Session_Val { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string Message { get; set; }
        public string MessageSuccessFully { get; set; }
        public IList<HomeModel> UsersList { get; set; }
        public IList<NagativeStock> nagativeStockList { get; set; }
        public List<SelectListItem> userList { get; set; }
        public List<SelectListItem> statusList { get; set; }
    }
    public class NagativeStock : tblNegativeStockNotification
    {
        public long ID { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string BrandName { get; set; }
        public double Stock { get; set; }
        public long SalesInvoiceId { get; set; }
        public DateTime? Date { get; set; }
        public bool? Aprove { get; set; }
        public string AproveRemark { get; set; }
        public string UserName { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceType { get; set; }
        public string AproovedBy { get; set; }
    }
    public class Menu
    {

        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int? PageId { get; set; }

        public string PageName { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string DisplayText { get; set; }
        public int MenuLevel { get; set; }
        public int ParentMenuId { get; set; }
        public string ShortCut { get; set; }
        public int SortId { get; set; }
        public bool IsParent { get; set; }
        public bool IsActive { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int Level { get; set; }


        // public List<Menu> MenuList { get; set; }
    }


    public class Store 
    {
        public Store()
        {
            StoreList = new List<SelectListItem>();
            StoreItemList = new List<Store>();
        }
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string StateName { get; set; }
        public List<SelectListItem> StoreList { get; set; }
        public IList<Store> StoreItemList { get; set; }
    }


    public class MenuInfo
    {
        public Menu GetsetMenuInfo { get; set; }
    }
}