using System;
    using System.Collections.Generic;
    using System.Text;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    
    namespace Script
    {
    
    public class TestEntities
    {
    public ISTRunTimeContext Context = null;
    public Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource> dataSourceNameToDataSource = new Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource>();
    
    protected HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource GetDataSource(string dataSourceName)
    {
    if(!dataSourceNameToDataSource.ContainsKey(dataSourceName))
    	throw new Exception(("A data source with the specified name does not exist."));
    return dataSourceNameToDataSource[dataSourceName];
    }
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity27 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity24 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity21 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity18 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity15 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity17 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity20 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity23 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity26 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity29 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity30 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity16 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity19 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity22 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity25 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity28 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence13 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity7 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity5 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity8 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop12Input> Loop12 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence14 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity11 = null;
    
    }
    
    }
    