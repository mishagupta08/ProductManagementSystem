﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductManagementSystemData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PMSEntities : DbContext
    {
        public PMSEntities()
            : base("name=PMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_Users> aspnet_Users { get; set; }
        public DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public DbSet<Brand1> Brand1 { get; set; }
        public DbSet<DeleteStock> DeleteStocks { get; set; }
        public DbSet<myTransaction> myTransactions { get; set; }
        public DbSet<PartyBrandDisc> PartyBrandDiscs { get; set; }
        public DbSet<ReferenceTypeMaster> ReferenceTypeMasters { get; set; }
        public DbSet<tb_GiftVoucherDetails> tb_GiftVoucherDetails { get; set; }
        public DbSet<tb_GiftVoucherTermsandConditions> tb_GiftVoucherTermsandConditions { get; set; }
        public DbSet<tb_TermsMaster> tb_TermsMaster { get; set; }
        public DbSet<tbl_UpdateItem> tbl_UpdateItem { get; set; }
        public DbSet<tbl_UpdateLog> tbl_UpdateLog { get; set; }
        public DbSet<tbl_UpdateTransactionType> tbl_UpdateTransactionType { get; set; }
        public DbSet<tblAccSelection> tblAccSelections { get; set; }
        public DbSet<tblAddress> tblAddresses { get; set; }
        public DbSet<tblAddressType> tblAddressTypes { get; set; }
        public DbSet<tblBrandMaster> tblBrandMasters { get; set; }
        public DbSet<tblCityMaster> tblCityMasters { get; set; }
        public DbSet<tblCompanyGroup> tblCompanyGroups { get; set; }
        public DbSet<tblCompanyMaster> tblCompanyMasters { get; set; }
        public DbSet<tblContraVoucher> tblContraVouchers { get; set; }
        public DbSet<tblContraVoucherLedger> tblContraVoucherLedgers { get; set; }
        public DbSet<tblcountry_tbl> tblcountry_tbl { get; set; }
        public DbSet<tblcountrystate_tbl> tblcountrystate_tbl { get; set; }
        public DbSet<tblCrditNoteToLedger> tblCrditNoteToLedgers { get; set; }
        public DbSet<tblCrditNoteToLedgerItem> tblCrditNoteToLedgerItems { get; set; }
        public DbSet<tblCreditItemsToDiscount> tblCreditItemsToDiscounts { get; set; }
        public DbSet<tblCreditNote> tblCreditNotes { get; set; }
        public DbSet<tblCreditNoteItemDiscount> tblCreditNoteItemDiscounts { get; set; }
        public DbSet<tblCreditNoteItem> tblCreditNoteItems { get; set; }
        public DbSet<tblCreditNoteItemsToTax> tblCreditNoteItemsToTaxes { get; set; }
        public DbSet<tblCreditNoteLatest> tblCreditNoteLatests { get; set; }
        public DbSet<tblCreditNoteToDiscount> tblCreditNoteToDiscounts { get; set; }
        public DbSet<tblCreditNoteToExtraCharge> tblCreditNoteToExtraCharges { get; set; }
        public DbSet<tblCreditNoteToTax> tblCreditNoteToTaxes { get; set; }
        public DbSet<tblCustomerBrandDisc> tblCustomerBrandDiscs { get; set; }
        public DbSet<TblCustomerGroup> TblCustomerGroups { get; set; }
        public DbSet<tblCustomerMaster> tblCustomerMasters { get; set; }
        public DbSet<tblDebitNote> tblDebitNotes { get; set; }
        public DbSet<tblDebitNoteItem> tblDebitNoteItems { get; set; }
        public DbSet<tblDebitNoteItemDiscount> tblDebitNoteItemDiscounts { get; set; }
        public DbSet<tblDebitNoteItemsToDiscount> tblDebitNoteItemsToDiscounts { get; set; }
        public DbSet<tblDebitNoteItemsToTax> tblDebitNoteItemsToTaxes { get; set; }
        public DbSet<tblDebitNoteToDiscount> tblDebitNoteToDiscounts { get; set; }
        public DbSet<tblDebitNoteToLedger> tblDebitNoteToLedgers { get; set; }
        public DbSet<tblDebitNoteToLedgerItem> tblDebitNoteToLedgerItems { get; set; }
        public DbSet<tblDebitNoteToTax> tblDebitNoteToTaxes { get; set; }
        public DbSet<tblDefaultGroup> tblDefaultGroups { get; set; }
        public DbSet<tblDefaultLedger> tblDefaultLedgers { get; set; }
        public DbSet<tblDiscountTypeMaster> tblDiscountTypeMasters { get; set; }
        public DbSet<tblDurationIn> tblDurationIns { get; set; }
        public DbSet<tblForgetPasswordQuestion> tblForgetPasswordQuestions { get; set; }
        public DbSet<tblFPCustomerMaster> tblFPCustomerMasters { get; set; }
        public DbSet<tblFPInvoiceStatu> tblFPInvoiceStatus { get; set; }
        public DbSet<tblGiftVoucherExtensionMaster> tblGiftVoucherExtensionMasters { get; set; }
        public DbSet<tblGiftVoucherIssue> tblGiftVoucherIssues { get; set; }
        public DbSet<tblGiftVoucherMaster> tblGiftVoucherMasters { get; set; }
        public DbSet<tblGodownMaster> tblGodownMasters { get; set; }
        public DbSet<tblGodownToUser> tblGodownToUsers { get; set; }
        public DbSet<TblGroupMaster> TblGroupMasters { get; set; }
        public DbSet<tblInventoryVoucher> tblInventoryVouchers { get; set; }
        public DbSet<tblInvoiceTypeMaster> tblInvoiceTypeMasters { get; set; }
        public DbSet<tblInword> tblInwords { get; set; }
        public DbSet<tblInwordItem> tblInwordItems { get; set; }
        public DbSet<tblInwordItemToDiscount> tblInwordItemToDiscounts { get; set; }
        public DbSet<tblInwordItemToTAX> tblInwordItemToTAXes { get; set; }
        public DbSet<tblInwordToDiscount> tblInwordToDiscounts { get; set; }
        public DbSet<tblInwordToPORef> tblInwordToPORefs { get; set; }
        public DbSet<tblInwordToTAX> tblInwordToTAXes { get; set; }
        public DbSet<tblItemCategoryMaster> tblItemCategoryMasters { get; set; }
        public DbSet<tblItemGridColumnPermission> tblItemGridColumnPermissions { get; set; }
        public DbSet<tblItemListForSyncronize> tblItemListForSyncronizes { get; set; }
        public DbSet<tblItemMaster> tblItemMasters { get; set; }
        public DbSet<tblItemMaster22Nov2014Backup> tblItemMaster22Nov2014Backup { get; set; }
        public DbSet<tblItemMasterBackup> tblItemMasterBackups { get; set; }
        public DbSet<tblItemRunningStock> tblItemRunningStocks { get; set; }
        public DbSet<tblItemToOtherExpens> tblItemToOtherExpenses { get; set; }
        public DbSet<tblItemToSubItem> tblItemToSubItems { get; set; }
        public DbSet<tblItemToTAXGroupSateWise> tblItemToTAXGroupSateWises { get; set; }
        public DbSet<tblItemToTaxProfile> tblItemToTaxProfiles { get; set; }
        public DbSet<tblItemWiseUnitConversion> tblItemWiseUnitConversions { get; set; }
        public DbSet<tblJournalVoucher> tblJournalVouchers { get; set; }
        public DbSet<tblJournalVoucherItemsToDiscount> tblJournalVoucherItemsToDiscounts { get; set; }
        public DbSet<tblJournalVoucherItemsToTax> tblJournalVoucherItemsToTaxes { get; set; }
        public DbSet<tblJournalVoucherToDiscount> tblJournalVoucherToDiscounts { get; set; }
        public DbSet<tblJournalVoucherToLedgerItem> tblJournalVoucherToLedgerItems { get; set; }
        public DbSet<tblJournalVoucherToTax> tblJournalVoucherToTaxes { get; set; }
        public DbSet<tblJVToLedger> tblJVToLedgers { get; set; }
        public DbSet<tblLog> tblLogs { get; set; }
        public DbSet<tblLogDataType> tblLogDataTypes { get; set; }
        public DbSet<tblModuleMaster> tblModuleMasters { get; set; }
        public DbSet<tblNature> tblNatures { get; set; }
        public DbSet<tblNegativeStockNotification> tblNegativeStockNotifications { get; set; }
        public DbSet<tblOnlineSalesInvoice> tblOnlineSalesInvoices { get; set; }
        public DbSet<tblOnlineSKUMapping> tblOnlineSKUMappings { get; set; }
        public DbSet<tblOpeningStock> tblOpeningStocks { get; set; }
        public DbSet<tblOutword> tblOutwords { get; set; }
        public DbSet<tblOutword_6THFloorremove> tblOutword_6THFloorremove { get; set; }
        public DbSet<tblOutwordItem> tblOutwordItems { get; set; }
        public DbSet<tblOutwordItemst6thfloor> tblOutwordItemst6thfloor { get; set; }
        public DbSet<tblOutwordItemToDiscount> tblOutwordItemToDiscounts { get; set; }
        public DbSet<tblOutwordItemToTAX> tblOutwordItemToTAXes { get; set; }
        public DbSet<tblOutwordToDiscount> tblOutwordToDiscounts { get; set; }
        public DbSet<tblOutwordToTAX> tblOutwordToTAXes { get; set; }
        public DbSet<tblParty_Master> tblParty_Master { get; set; }
        public DbSet<tblPartyGroupMaster> tblPartyGroupMasters { get; set; }
        public DbSet<tblPartyToGroup> tblPartyToGroups { get; set; }
        public DbSet<tblPayment_Type_Master> tblPayment_Type_Master { get; set; }
        public DbSet<tblPaymentToRefence> tblPaymentToRefences { get; set; }
        public DbSet<tblPaymentVoucher> tblPaymentVouchers { get; set; }
        public DbSet<tblPaymentVoucherToLedger> tblPaymentVoucherToLedgers { get; set; }
        public DbSet<tblPhone> tblPhones { get; set; }
        public DbSet<tblProductionConsunption> tblProductionConsunptions { get; set; }
        public DbSet<tblPurchaseInvoice> tblPurchaseInvoices { get; set; }
        public DbSet<tblPurchaseInvoice8112014> tblPurchaseInvoice8112014 { get; set; }
        public DbSet<tblPurchaseInvoiceItem> tblPurchaseInvoiceItems { get; set; }
        public DbSet<tblPurchaseInvoiceItems8112014> tblPurchaseInvoiceItems8112014 { get; set; }
        public DbSet<tblPurchaseInvoiceItemToDiscount> tblPurchaseInvoiceItemToDiscounts { get; set; }
        public DbSet<tblPurchaseInvoiceItemToTax> tblPurchaseInvoiceItemToTaxes { get; set; }
        public DbSet<tblPurchaseInvoiceToDiscount> tblPurchaseInvoiceToDiscounts { get; set; }
        public DbSet<tblPurchaseInvoiceToExtraCharge> tblPurchaseInvoiceToExtraCharges { get; set; }
        public DbSet<tblPurchaseInvoiceToInword> tblPurchaseInvoiceToInwords { get; set; }
        public DbSet<tblPurchaseInvoiceToLedger> tblPurchaseInvoiceToLedgers { get; set; }
        public DbSet<tblPurchaseInvoiceToPoNo> tblPurchaseInvoiceToPoNoes { get; set; }
        public DbSet<tblPurchaseInvoiceToReference> tblPurchaseInvoiceToReferences { get; set; }
        public DbSet<tblPurchaseInvoiceToTax> tblPurchaseInvoiceToTaxes { get; set; }
        public DbSet<tblPurchaseOrder> tblPurchaseOrders { get; set; }
        public DbSet<tblPurchaseOrderDiscount> tblPurchaseOrderDiscounts { get; set; }
        public DbSet<tblPurchaseOrderItem> tblPurchaseOrderItems { get; set; }
        public DbSet<tblPurchaseOrderItemTax> tblPurchaseOrderItemTaxes { get; set; }
        public DbSet<tblPurchaseOrderItemToDiscount> tblPurchaseOrderItemToDiscounts { get; set; }
        public DbSet<tblPurchaseOrderToTax> tblPurchaseOrderToTaxes { get; set; }
        public DbSet<tblQuotation> tblQuotations { get; set; }
        public DbSet<tblQuotationItem> tblQuotationItems { get; set; }
        public DbSet<tblQuotItemsToDiscount> tblQuotItemsToDiscounts { get; set; }
        public DbSet<tblQuotItemsToTAX> tblQuotItemsToTAXes { get; set; }
        public DbSet<tblQuotToDiscount> tblQuotToDiscounts { get; set; }
        public DbSet<tblQuotToTAX> tblQuotToTAXes { get; set; }
        public DbSet<tblRackMaster> tblRackMasters { get; set; }
        public DbSet<tblReceiptToRefence> tblReceiptToRefences { get; set; }
        public DbSet<tblRecieptVoucher> tblRecieptVouchers { get; set; }
        public DbSet<tblRecieptVoucherToLeger> tblRecieptVoucherToLegers { get; set; }
        public DbSet<tblRejectionIn> tblRejectionIns { get; set; }
        public DbSet<tblRejectionInItem> tblRejectionInItems { get; set; }
        public DbSet<tblRejectionInItemToDiscount> tblRejectionInItemToDiscounts { get; set; }
        public DbSet<tblRejectionInItemToTAX> tblRejectionInItemToTAXes { get; set; }
        public DbSet<tblRejectionOut> tblRejectionOuts { get; set; }
        public DbSet<tblRejectionOutItem> tblRejectionOutItems { get; set; }
        public DbSet<tblRejectionOutItemToDiscount> tblRejectionOutItemToDiscounts { get; set; }
        public DbSet<tblRejectionOutItemToTAX> tblRejectionOutItemToTAXes { get; set; }
        public DbSet<tblReportColumn> tblReportColumns { get; set; }
        public DbSet<tblRequestMaster> tblRequestMasters { get; set; }
        public DbSet<tblRequestToExpense> tblRequestToExpenses { get; set; }
        public DbSet<tblRequestToItem> tblRequestToItems { get; set; }
        public DbSet<tblSalesInvoice> tblSalesInvoices { get; set; }
        public DbSet<tblSalesInvoiceItem> tblSalesInvoiceItems { get; set; }
        public DbSet<tblSalesInvoiceItemToDiscount> tblSalesInvoiceItemToDiscounts { get; set; }
        public DbSet<tblSalesInvoiceItemToTax> tblSalesInvoiceItemToTaxes { get; set; }
        public DbSet<tblSalesInvoicePayment> tblSalesInvoicePayments { get; set; }
        public DbSet<tblSalesInvoiceToDiscount> tblSalesInvoiceToDiscounts { get; set; }
        public DbSet<tblSalesInvoicetoExtraCharge> tblSalesInvoicetoExtraCharges { get; set; }
        public DbSet<tblSalesInvoiceToLedger> tblSalesInvoiceToLedgers { get; set; }
        public DbSet<tblSalesInvoiceToReference> tblSalesInvoiceToReferences { get; set; }
        public DbSet<tblSalesInvoiceToTax> tblSalesInvoiceToTaxes { get; set; }
        public DbSet<tblSalesInvoieToRedemption> tblSalesInvoieToRedemptions { get; set; }
        public DbSet<tblSalesOrder> tblSalesOrders { get; set; }
        public DbSet<tblSalesOrderItem> tblSalesOrderItems { get; set; }
        public DbSet<tblSalesOrderItemToDiscount> tblSalesOrderItemToDiscounts { get; set; }
        public DbSet<tblSalesOrderItemToTAX> tblSalesOrderItemToTAXes { get; set; }
        public DbSet<tblSalesOrderToDiscount> tblSalesOrderToDiscounts { get; set; }
        public DbSet<tblSalesOrderToTax> tblSalesOrderToTaxes { get; set; }
        public DbSet<tblSalutation_tbl> tblSalutation_tbl { get; set; }
        public DbSet<tblSectionMaster> tblSectionMasters { get; set; }
        public DbSet<tblStateMaster> tblStateMasters { get; set; }
        public DbSet<tblstatesuburb_Tbl> tblstatesuburb_Tbl { get; set; }
        public DbSet<tblStatusMaster> tblStatusMasters { get; set; }
        public DbSet<tblStockCountingCycleMaster> tblStockCountingCycleMasters { get; set; }
        public DbSet<tblStockCountingTypeMaster> tblStockCountingTypeMasters { get; set; }
        public DbSet<tblStockCountingVoucherMaster> tblStockCountingVoucherMasters { get; set; }
        public DbSet<tblStockCountingVoucherToItem> tblStockCountingVoucherToItems { get; set; }
        public DbSet<tblStockJournal> tblStockJournals { get; set; }
        public DbSet<tblStockJournalToExpense> tblStockJournalToExpenses { get; set; }
        public DbSet<tblStockJournalToItem> tblStockJournalToItems { get; set; }
        public DbSet<tblStockJournalToPartyToItem> tblStockJournalToPartyToItems { get; set; }
        public DbSet<tblStoreMaster> tblStoreMasters { get; set; }
        public DbSet<tblTAXGroupMaster> tblTAXGroupMasters { get; set; }
        public DbSet<tblTaxGroupToStateWiseTaxProfile> tblTaxGroupToStateWiseTaxProfiles { get; set; }
        public DbSet<tblTaxProfileCategoryMaster> tblTaxProfileCategoryMasters { get; set; }
        public DbSet<tblTaxProfileDetail> tblTaxProfileDetails { get; set; }
        public DbSet<tblTaxProfileMaster> tblTaxProfileMasters { get; set; }
        public DbSet<tblTaxTypeMaster> tblTaxTypeMasters { get; set; }
        public DbSet<tblTransportComanyMaster> tblTransportComanyMasters { get; set; }
        public DbSet<tblTransportTypeMaster> tblTransportTypeMasters { get; set; }
        public DbSet<tblUnitConversion> tblUnitConversions { get; set; }
        public DbSet<tblUnitMaster> tblUnitMasters { get; set; }
        public DbSet<tblUserMaster> tblUserMasters { get; set; }
        public DbSet<tblUserPermission> tblUserPermissions { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblUserToCompany> tblUserToCompanies { get; set; }
        public DbSet<tblUserTypeMaster> tblUserTypeMasters { get; set; }
        public DbSet<tblWorkOrder> tblWorkOrders { get; set; }
        public DbSet<tblWorkOrder_Items> tblWorkOrder_Items { get; set; }
        public DbSet<tblWorkOrder_OtherCharges> tblWorkOrder_OtherCharges { get; set; }
        public DbSet<TempCheck> TempChecks { get; set; }
        public DbSet<TempClose> TempCloses { get; set; }
        public DbSet<TempCreditNote> TempCreditNotes { get; set; }
        public DbSet<TempCreditnote311014> TempCreditnote311014 { get; set; }
        public DbSet<TempCRNote> TempCRNotes { get; set; }
        public DbSet<TEMPD1> TEMPD1 { get; set; }
        public DbSet<TempDelete9> TempDelete9 { get; set; }
        public DbSet<TempFinalStock> TempFinalStocks { get; set; }
        public DbSet<TempItemList> TempItemLists { get; set; }
        public DbSet<TempItemNegative> TempItemNegatives { get; set; }
        public DbSet<TempLocationWiseTransaction> TempLocationWiseTransactions { get; set; }
        public DbSet<TempM1> TempM1 { get; set; }
        public DbSet<TempM6Floor> TempM6Floor { get; set; }
        public DbSet<TempMerge1> TempMerge1 { get; set; }
        public DbSet<TempMergeStock1> TempMergeStock1 { get; set; }
        public DbSet<TempPurchaseIN> TempPurchaseINs { get; set; }
        public DbSet<TempPurchaseInvoice_N> TempPurchaseInvoice_N { get; set; }
        public DbSet<TempSalesInvoice> TempSalesInvoices { get; set; }
        public DbSet<TempSalesInvoice3112014> TempSalesInvoice3112014 { get; set; }
        public DbSet<TempStock> TempStocks { get; set; }
        public DbSet<TempStock1> TempStock1 { get; set; }
        public DbSet<TempStock3> TempStock3 { get; set; }
        public DbSet<tempStock4> tempStock4 { get; set; }
        public DbSet<TempStock5> TempStock5 { get; set; }
        public DbSet<TempStock6> TempStock6 { get; set; }
        public DbSet<tempStock7> tempStock7 { get; set; }
        public DbSet<TempStockCI> TempStockCIs { get; set; }
        public DbSet<TempStockCountingItem> TempStockCountingItems { get; set; }
        public DbSet<TempStockCountingVoucher> TempStockCountingVouchers { get; set; }
        public DbSet<TempStockCountingVoucherMaster> TempStockCountingVoucherMasters { get; set; }
        public DbSet<TempStockj> TempStockjs { get; set; }
        public DbSet<TEMPStockJVItem> TEMPStockJVItems { get; set; }
        public DbSet<TempStockOrg> TempStockOrgs { get; set; }
        public DbSet<TempStockV> TempStockVs { get; set; }
        public DbSet<TemptblStockCountingVoucherToItem> TemptblStockCountingVoucherToItems { get; set; }
        public DbSet<TempTransaction31Mar> TempTransaction31Mar { get; set; }
        public DbSet<TempTransactionItem> TempTransactionItems { get; set; }
        public DbSet<VatUpdateFromToycra> VatUpdateFromToycras { get; set; }
    }
}
