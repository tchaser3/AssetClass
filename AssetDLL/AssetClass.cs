/* Title:           Asset Class
 * Date:            6-17-20
 * Author:          Terry Holmes
 * 
 * Description:     This is the class that controls the assets */

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace AssetDLL
{
    public class AssetClass
    {
        //setting up the classess
        EventLogClass TheEventLogClass = new EventLogClass();

        AssetAssignmentHistoryDataSet aAssetAssignmentHistoryDataSet;
        AssetAssignmentHistoryDataSetTableAdapters.assetassignmenthistoryTableAdapter aAssetAssignmentHistoryTableAdapter;

        InsertAssetAssignmentHistoryEntryTableAdapters.QueriesTableAdapter aInsertAssetAssignmentHistoryTableAdapter;

        FindAssetAssignHistoryByAssetIDDataSet aFindAssetAssignHistoryByAssetIDDataSet;
        FindAssetAssignHistoryByAssetIDDataSetTableAdapters.FindAssetAssignHistoryByAssetIDTableAdapter aFindAssetAssignHistoryByAssetIDTableAdapter;

        FindAssetAssignmentHistoryByDateRangeDataSet aFindAssetAssignmentHistoryByDateRangeDataSet;
        FindAssetAssignmentHistoryByDateRangeDataSetTableAdapters.FindAssetAssignmentHistoryByDateRangeTableAdapter aFindAssetAssignmentHistoryByDateRangeTableAdapter;

        AccountingAssetsDataSet aAccountingAssetsDataSet;
        AccountingAssetsDataSetTableAdapters.accountingassetsTableAdapter aAccountingAssetsTableAdapter;

        InsertAccountingAssetEntryTableAdapters.QueriesTableAdapter aInsertAccountingAssetTableAdapter;

        FindActiveAccountingAssetsByValueDataSet aFindActiveAccountingAssetsByValueDataSet;
        FindActiveAccountingAssetsByValueDataSetTableAdapters.FindActiveAccountingAssetsByValueTableAdapter aFindActiveAccountingAssetsByValueTableAdapter;

        FindAccountingAssetbyAssetIDDataSet aFindAccountingAssetByAssetIDDataSet;
        FindAccountingAssetbyAssetIDDataSetTableAdapters.FindAccountingAssetByAssetIDTableAdapter aFindAccountingAssetByAssetIDTableAdapter;

        UpdateAccountingAssetCurrentValueEntryTableAdapters.QueriesTableAdapter aUpdateAccountingAssetCurrentValueTableAdapter;

        FindActiveAccountingAssetsByAccountNumberDataSet aFindActiveAccountingAssetsByAccountNumberDataSet;
        FindActiveAccountingAssetsByAccountNumberDataSetTableAdapters.FindActiveAccountingAssetsByAccountNumberTableAdapter aFindActiveAccountingAssetsByAccountNumberTableAdapter;

        AccountingAssetDepreciationHistoryDataSet aAccountingAssetDepreciationHistoryDataSet;
        AccountingAssetDepreciationHistoryDataSetTableAdapters.accountingassetdepreciationhistoryTableAdapter aAccountingAssetDepreciationHistoryTableAdapter;

        InsertAccountingAssetDepreciationHistoryEntryTableAdapters.QueriesTableAdapter aInsertAccountingAssetDepreciationHistoryTableAdapter;

        FindAccountingAssetDepreciationHistoryByAssetIDDataSet aFindAccoutingAssetDepreciationHistoryByAssetIDDataSet;
        FindAccountingAssetDepreciationHistoryByAssetIDDataSetTableAdapters.FindAccountingAssetDepreciationHistoryByAssetIDTableAdapter aFindAccoutingAssetDepreciationHistoryByAssetIDTableAdapter;

        AssetMainDataSet aAssetMainDataSet;
        AssetMainDataSetTableAdapters.assetmainTableAdapter aAssetMainTableAdapter;

        InsertAssetMainEntryTableAdapters.QueriesTableAdapter aInsertAssetMainTableAdapter;

        UpdateAssetMainEmployeeEntryTableAdapters.QueriesTableAdapter aUpdateAssetMainEmployeeTableAdapter;

        UpdateAssetMainWarehouseEntryTableAdapters.QueriesTableAdapter aUpdateAssetMainWarehouseTableAdapter;

        RetireAssetMainEntryTableAdapters.QueriesTableAdapter aRetireAssetMainTableAdapter;

        FindActiveAssetMainDataSet aFindActiveAssetMainDataSet;
        FindActiveAssetMainDataSetTableAdapters.FindActiveAssetMainTableAdapter aFindActiveAssetMainTableAdapter;

        FindActiveAssetMainByLocationDataSet aFindActiveAssetMainByLocationDataSet;
        FindActiveAssetMainByLocationDataSetTableAdapters.FindActiveAssetMainByLocationTableAdapter aFindActiveAssetMainByLocationTableAdapter;

        FindActiveAssetMainByEmployeeDataSet aFindActiveAssetMainByEmployeeDataSet;
        FindActiveAssetMainByEmployeeDataSetTableAdapters.FindActiveAssetMainByEmployeeTableAdapter aFindActiveAssetMainByEmployeeTableAdapter;

        AssetTypeDataSet aAssetTypeDataSet;
        AssetTypeDataSetTableAdapters.assettypeTableAdapter aAssetTypeTableAdapter;

        InsertAssetTypeEntryTableAdapters.QueriesTableAdapter aInsertAssetTypeTableAdapter;

        FindSortedAssetTypesDataSet aFindSortedAssetTypesDataSet;
        FindSortedAssetTypesDataSetTableAdapters.FindSortedAssetTypesTableAdapter aFindSortedAssetTypesTableAdapter;

        FindAssetTypeByAssetTypeIDDataSet aFindAssetTypeByAssetTypeIDDataSet;
        FindAssetTypeByAssetTypeIDDataSetTableAdapters.FindAssetTypeByAssetTypeIDTableAdapter aFindAssetTypeByAssetTypeIDTableAdapter;

        FindAssetTypeByAssetTypeDataSet aFindAssetTypeByAssetTypeDataSet;
        FindAssetTypeByAssetTypeDataSetTableAdapters.FindAssetTypeByAssetTypeTableAdapter aFindAssetTypeByAssetTypeTableAdapter;

        FindAssetMainBySerialNumberDataSet aFindAssetMainBySerialNumberDataSet;
        FindAssetMainBySerialNumberDataSetTableAdapters.FindAssetMainBySerialNumberTableAdapter aFindAssetMainBySerialNumberTableAdapter;

        public FindAssetMainBySerialNumberDataSet FindAssetMainBySerialNumber(string strSerialNumber)
        {
            try
            {
                aFindAssetMainBySerialNumberDataSet = new FindAssetMainBySerialNumberDataSet();
                aFindAssetMainBySerialNumberTableAdapter = new FindAssetMainBySerialNumberDataSetTableAdapters.FindAssetMainBySerialNumberTableAdapter();
                aFindAssetMainBySerialNumberTableAdapter.Fill(aFindAssetMainBySerialNumberDataSet.FindAssetMainBySerialNumber, strSerialNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Asset Main By Serial Number " + Ex.Message);
            }

            return aFindAssetMainBySerialNumberDataSet;
        }
        public FindAssetTypeByAssetTypeDataSet FindAssetTypeByAssetType(string strAssetType)
        {
            try
            {
                aFindAssetTypeByAssetTypeDataSet = new FindAssetTypeByAssetTypeDataSet();
                aFindAssetTypeByAssetTypeTableAdapter = new FindAssetTypeByAssetTypeDataSetTableAdapters.FindAssetTypeByAssetTypeTableAdapter();
                aFindAssetTypeByAssetTypeTableAdapter.Fill(aFindAssetTypeByAssetTypeDataSet.FindAssetTypeByAssetType, strAssetType);
            }
            catch (Exception eX)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Asset Type By Asset Type " + eX.Message);
            }

            return aFindAssetTypeByAssetTypeDataSet;
        }
        public FindAssetTypeByAssetTypeIDDataSet FindAssetTypeByAssetTypeID(int intAssetTypeID)
        {
            try
            {
                aFindAssetTypeByAssetTypeIDDataSet = new FindAssetTypeByAssetTypeIDDataSet();
                aFindAssetTypeByAssetTypeIDTableAdapter = new FindAssetTypeByAssetTypeIDDataSetTableAdapters.FindAssetTypeByAssetTypeIDTableAdapter();
                aFindAssetTypeByAssetTypeIDTableAdapter.Fill(aFindAssetTypeByAssetTypeIDDataSet.FindAssetTypeByAssetTypeID, intAssetTypeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Asset Type By Asset Type ID " + Ex.Message);
            }

            return aFindAssetTypeByAssetTypeIDDataSet;
        }
        public FindSortedAssetTypesDataSet FindSortedAssetTypes()
        {
            try
            {
                aFindSortedAssetTypesDataSet = new FindSortedAssetTypesDataSet();
                aFindSortedAssetTypesTableAdapter = new FindSortedAssetTypesDataSetTableAdapters.FindSortedAssetTypesTableAdapter();
                aFindSortedAssetTypesTableAdapter.Fill(aFindSortedAssetTypesDataSet.FindSortedAssetTypes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Sorted Asset Type " + Ex.Message);
            }

            return aFindSortedAssetTypesDataSet;
        }
        public bool InsertAssetType(string strAssetType)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAssetTypeTableAdapter = new InsertAssetTypeEntryTableAdapters.QueriesTableAdapter();
                aInsertAssetTypeTableAdapter.InsertAssetType(strAssetType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Insert Asset Type " + Ex.Message);
            }

            return blnFatalError;
        }
        public AssetTypeDataSet GetAssetTypeInfo()
        {
            try
            {
                aAssetTypeDataSet = new AssetTypeDataSet();
                aAssetTypeTableAdapter = new AssetTypeDataSetTableAdapters.assettypeTableAdapter();
                aAssetTypeTableAdapter.Fill(aAssetTypeDataSet.assettype);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Get Asset Type Info " + Ex.Message);
            }

            return aAssetTypeDataSet;
        }
        public void UpdateAssetTypeDB(AssetTypeDataSet aAssetTypeDataSet)
        {
            try
            {
                aAssetTypeTableAdapter = new AssetTypeDataSetTableAdapters.assettypeTableAdapter();
                aAssetTypeTableAdapter.Update(aAssetTypeDataSet.assettype);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Asset Type DB " + Ex.Message);
            }
        }
        public FindActiveAssetMainByEmployeeDataSet FindActiveAssetMainByEmployee(int intEmployeeID)
        {
            try
            {
                aFindActiveAssetMainByEmployeeDataSet = new FindActiveAssetMainByEmployeeDataSet();
                aFindActiveAssetMainByEmployeeTableAdapter = new FindActiveAssetMainByEmployeeDataSetTableAdapters.FindActiveAssetMainByEmployeeTableAdapter();
                aFindActiveAssetMainByEmployeeTableAdapter.Fill(aFindActiveAssetMainByEmployeeDataSet.FindActiveAssetMainByEmployee, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Active Asset Main By Employee " + Ex.Message);
            }

            return aFindActiveAssetMainByEmployeeDataSet;
        }
        public FindActiveAssetMainByLocationDataSet FindActiveAssetMainByLocation(int intWarehouseID)
        {
            try
            {
                aFindActiveAssetMainByLocationDataSet = new FindActiveAssetMainByLocationDataSet();
                aFindActiveAssetMainByLocationTableAdapter = new FindActiveAssetMainByLocationDataSetTableAdapters.FindActiveAssetMainByLocationTableAdapter();
                aFindActiveAssetMainByLocationTableAdapter.Fill(aFindActiveAssetMainByLocationDataSet.FindActiveAssetMainByLocation, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Active Asset Main By Location " + Ex.Message);
            }

            return aFindActiveAssetMainByLocationDataSet;
        }
        public FindActiveAssetMainDataSet FindActiveAssetMain()
        {
            try
            {
                aFindActiveAssetMainDataSet = new FindActiveAssetMainDataSet();
                aFindActiveAssetMainTableAdapter = new FindActiveAssetMainDataSetTableAdapters.FindActiveAssetMainTableAdapter();
                aFindActiveAssetMainTableAdapter.Fill(aFindActiveAssetMainDataSet.FindActiveAssetMain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Active Asset Main " + Ex.Message);
            }

            return aFindActiveAssetMainDataSet;
        }
        public bool RetireAssetMain(int intAssetID, DateTime datRetirementDate, string strRetirementNotes)
        {
            bool blnFatalError = false;

            try
            {
                aRetireAssetMainTableAdapter = new RetireAssetMainEntryTableAdapters.QueriesTableAdapter();
                aRetireAssetMainTableAdapter.RetireAssetMain(intAssetID, datRetirementDate, strRetirementNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Retire Asset Main " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateAssetMainWarehouse(int intAssetID, int intWarehouseID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAssetMainWarehouseTableAdapter = new UpdateAssetMainWarehouseEntryTableAdapters.QueriesTableAdapter();
                aUpdateAssetMainWarehouseTableAdapter.UpateAssetMainWarehouse(intAssetID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Asset Main Warehouse " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateAssetMainEmployee(int intAssetID, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAssetMainEmployeeTableAdapter = new UpdateAssetMainEmployeeEntryTableAdapters.QueriesTableAdapter();
                aUpdateAssetMainEmployeeTableAdapter.UpdateAssetMainEmployee(intAssetID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Asset Main Employee " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertAssetMain(string strAssetPartNumber, int intAssetTypeID, string strAssetDescription, decimal decAssetCost, int intWarehouseID, int intEmployeeID, string strAssetNotes, DateTime datDataEntryDate, string strSerialNumber)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAssetMainTableAdapter = new InsertAssetMainEntryTableAdapters.QueriesTableAdapter();
                aInsertAssetMainTableAdapter.InsertAssetMain(strAssetPartNumber, intAssetTypeID, strAssetDescription, decAssetCost, intWarehouseID, intEmployeeID, DateTime.Now, strAssetNotes, datDataEntryDate, strSerialNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Insert Asset Main " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public AssetMainDataSet GetAssetMainInfo()
        {
            try
            {
                aAssetMainDataSet = new AssetMainDataSet();
                aAssetMainTableAdapter = new AssetMainDataSetTableAdapters.assetmainTableAdapter();
                aAssetMainTableAdapter.Fill(aAssetMainDataSet.assetmain);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Get Asset Main Info " + Ex.Message);
            }

            return aAssetMainDataSet;
        }
        public void UpdateAssetMainDB(AssetMainDataSet aAssetMainDataSet)
        {
            try
            {
                aAssetMainTableAdapter = new AssetMainDataSetTableAdapters.assetmainTableAdapter();
                aAssetMainTableAdapter.Update(aAssetMainDataSet.assetmain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Get Asset Main Info " + Ex.Message);
            }
        }
        public FindAccountingAssetDepreciationHistoryByAssetIDDataSet FindAccoutingAssetDepreciationHistory(int intAssetID)
        {
            try
            {
                aFindAccoutingAssetDepreciationHistoryByAssetIDDataSet = new FindAccountingAssetDepreciationHistoryByAssetIDDataSet();
                aFindAccoutingAssetDepreciationHistoryByAssetIDTableAdapter = new FindAccountingAssetDepreciationHistoryByAssetIDDataSetTableAdapters.FindAccountingAssetDepreciationHistoryByAssetIDTableAdapter();
                aFindAccoutingAssetDepreciationHistoryByAssetIDTableAdapter.Fill(aFindAccoutingAssetDepreciationHistoryByAssetIDDataSet.FindAccountingAssetDepreciationHistoryByAssetID, intAssetID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Accounting Asset Depreciation History By Asset ID " + Ex.Message);
            }

            return aFindAccoutingAssetDepreciationHistoryByAssetIDDataSet;
        }
        public bool InsertAccountingAssetDepreciationHistory(int intAssetID, decimal decCurrentValue)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAccountingAssetDepreciationHistoryTableAdapter = new InsertAccountingAssetDepreciationHistoryEntryTableAdapters.QueriesTableAdapter();
                aInsertAccountingAssetDepreciationHistoryTableAdapter.InsertAccountingAssetDepreciationHistory(intAssetID, DateTime.Now, decCurrentValue);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Insert Accounting Asset Depreciation History " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public AccountingAssetDepreciationHistoryDataSet GetAccountingAssetDepreciationHistoryInfo()
        {
            try
            {
                aAccountingAssetDepreciationHistoryDataSet = new AccountingAssetDepreciationHistoryDataSet();
                aAccountingAssetDepreciationHistoryTableAdapter = new AccountingAssetDepreciationHistoryDataSetTableAdapters.accountingassetdepreciationhistoryTableAdapter();
                aAccountingAssetDepreciationHistoryTableAdapter.Fill(aAccountingAssetDepreciationHistoryDataSet.accountingassetdepreciationhistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Get Accounting Asset Depreciation History Info " + Ex.Message);
            }

            return aAccountingAssetDepreciationHistoryDataSet;
        }
        public void UpdateAccountingDepreciationHistoryDB(AccountingAssetDepreciationHistoryDataSet aAccountingAssetDepreciationHistoryDataSet)
        {
            try
            {
                aAccountingAssetDepreciationHistoryTableAdapter = new AccountingAssetDepreciationHistoryDataSetTableAdapters.accountingassetdepreciationhistoryTableAdapter();
                aAccountingAssetDepreciationHistoryTableAdapter.Update(aAccountingAssetDepreciationHistoryDataSet.accountingassetdepreciationhistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Accounting Asset Depreciation History DB " + Ex.Message);
            }
        }
        public FindActiveAccountingAssetsByAccountNumberDataSet FindActiveAccountingAssetsByAccountNumber(string strAccountNumber)
        {
            try
            {
                aFindActiveAccountingAssetsByAccountNumberDataSet = new FindActiveAccountingAssetsByAccountNumberDataSet();
                aFindActiveAccountingAssetsByAccountNumberTableAdapter = new FindActiveAccountingAssetsByAccountNumberDataSetTableAdapters.FindActiveAccountingAssetsByAccountNumberTableAdapter();
                aFindActiveAccountingAssetsByAccountNumberTableAdapter.Fill(aFindActiveAccountingAssetsByAccountNumberDataSet.FindActiveAccountingAssetsByAccountNumber, strAccountNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Active Accounting Assets By Accounting Number " + Ex.Message);
            }

            return aFindActiveAccountingAssetsByAccountNumberDataSet;
        }
        public bool UpdateAccountingAssetCurrentValue(int intAssetID, decimal decCurrentValue)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAccountingAssetCurrentValueTableAdapter = new UpdateAccountingAssetCurrentValueEntryTableAdapters.QueriesTableAdapter();
                aUpdateAccountingAssetCurrentValueTableAdapter.UpdateAccountingAssetCurrentValue(intAssetID, decCurrentValue);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Accounting Asset Current Value " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindAccountingAssetbyAssetIDDataSet FindAccountingAssetByAssetID(int intAssetID)
        {
            try
            {
                aFindAccountingAssetByAssetIDDataSet = new FindAccountingAssetbyAssetIDDataSet();
                aFindAccountingAssetByAssetIDTableAdapter = new FindAccountingAssetbyAssetIDDataSetTableAdapters.FindAccountingAssetByAssetIDTableAdapter();
                aFindAccountingAssetByAssetIDTableAdapter.Fill(aFindAccountingAssetByAssetIDDataSet.FindAccountingAssetByAssetID, intAssetID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Accounting Asset By Asset ID " + Ex.Message);
            }

            return aFindAccountingAssetByAssetIDDataSet;
        }
        public FindActiveAccountingAssetsByValueDataSet FindActiveAccountAssetsByValue()
        {
            try
            {
                aFindActiveAccountingAssetsByValueDataSet = new FindActiveAccountingAssetsByValueDataSet();
                aFindActiveAccountingAssetsByValueTableAdapter = new FindActiveAccountingAssetsByValueDataSetTableAdapters.FindActiveAccountingAssetsByValueTableAdapter();
                aFindActiveAccountingAssetsByValueTableAdapter.Fill(aFindActiveAccountingAssetsByValueDataSet.FindActiveAccountingAssetsByValue);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Active Assets By Value " + Ex.Message);
            }

            return aFindActiveAccountingAssetsByValueDataSet;
        }
        public bool InsertAccountingAsset(int intAssetID, string strAccountNumber, int intDepreciationPeriod, DateTime datDepreciationDate, DateTime datDataEntryDate, decimal decStartingValue, decimal decCurrentValue, decimal decDepriecationRate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAccountingAssetTableAdapter = new InsertAccountingAssetEntryTableAdapters.QueriesTableAdapter();
                aInsertAccountingAssetTableAdapter.InsertAccountingAsset(intAssetID, strAccountNumber, intDepreciationPeriod, datDepreciationDate, datDataEntryDate, decStartingValue, decCurrentValue, decDepriecationRate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Insert Accounting Asset " + Ex.Message);
            }

            return blnFatalError;
        }
        public AccountingAssetsDataSet GetAccountAssetsInfo()
        {
            try
            {
                aAccountingAssetsDataSet = new AccountingAssetsDataSet();
                aAccountingAssetsTableAdapter = new AccountingAssetsDataSetTableAdapters.accountingassetsTableAdapter();
                aAccountingAssetsTableAdapter.Fill(aAccountingAssetsDataSet.accountingassets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Getting Accounting Assets Info " + Ex.Message);
            }

            return aAccountingAssetsDataSet;
        }
        public void UpdateAccountingAssetsDB(AccountingAssetsDataSet aAccountingAssetsDataSet)
        {
            try
            {
                aAccountingAssetsTableAdapter = new AccountingAssetsDataSetTableAdapters.accountingassetsTableAdapter();
                aAccountingAssetsTableAdapter.Update(aAccountingAssetsDataSet.accountingassets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Accounting Assets DB " + Ex.Message);
            }
        }
        public FindAssetAssignmentHistoryByDateRangeDataSet FindAssetAssignmentHistoryByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAssetAssignmentHistoryByDateRangeDataSet = new FindAssetAssignmentHistoryByDateRangeDataSet();
                aFindAssetAssignmentHistoryByDateRangeTableAdapter = new FindAssetAssignmentHistoryByDateRangeDataSetTableAdapters.FindAssetAssignmentHistoryByDateRangeTableAdapter();
                aFindAssetAssignmentHistoryByDateRangeTableAdapter.Fill(aFindAssetAssignmentHistoryByDateRangeDataSet.FindAssetAssignmentHistoryByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Asset Assignment History By Date Range " + Ex.Message);
            }

            return aFindAssetAssignmentHistoryByDateRangeDataSet;
        }
        public FindAssetAssignHistoryByAssetIDDataSet FindAssetAssignmentHistory(int intAssetID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAssetAssignHistoryByAssetIDDataSet = new FindAssetAssignHistoryByAssetIDDataSet();
                aFindAssetAssignHistoryByAssetIDTableAdapter = new FindAssetAssignHistoryByAssetIDDataSetTableAdapters.FindAssetAssignHistoryByAssetIDTableAdapter();
                aFindAssetAssignHistoryByAssetIDTableAdapter.Fill(aFindAssetAssignHistoryByAssetIDDataSet.FindAssetAssignHistoryByAssetID, intAssetID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Find Asset Assignment History " + Ex.Message);
            }

            return aFindAssetAssignHistoryByAssetIDDataSet;
        }
        public bool InsertAssetAssignmentHistory(int intAssetID, int intEmployeeID, string strTransactionNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAssetAssignmentHistoryTableAdapter = new InsertAssetAssignmentHistoryEntryTableAdapters.QueriesTableAdapter();
                aInsertAssetAssignmentHistoryTableAdapter.InsertAssetAssignmentHistory(intAssetID, intEmployeeID, DateTime.Now, strTransactionNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Insert Asset Assignment History " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public AssetAssignmentHistoryDataSet GetAssignAssignementHistory()
        {
            try
            {
                aAssetAssignmentHistoryDataSet = new AssetAssignmentHistoryDataSet();
                aAssetAssignmentHistoryTableAdapter = new AssetAssignmentHistoryDataSetTableAdapters.assetassignmenthistoryTableAdapter();
                aAssetAssignmentHistoryTableAdapter.Fill(aAssetAssignmentHistoryDataSet.assetassignmenthistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Get Asset Assignment History " + Ex.Message);
            }

            return aAssetAssignmentHistoryDataSet;
        }
        public void GetAssetAssignmentHistoryDB(AssetAssignmentHistoryDataSet aAssetAssignmentHistoryDataSet)
        {
            try
            {
                aAssetAssignmentHistoryTableAdapter = new AssetAssignmentHistoryDataSetTableAdapters.assetassignmenthistoryTableAdapter();
                aAssetAssignmentHistoryTableAdapter.Update(aAssetAssignmentHistoryDataSet.assetassignmenthistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Asset Class // Update Asset Assignment DB " + Ex.Message);
            }
        }
    }
}
