// Copyright 2018 Cohesity Inc.
using System.Linq;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;
using Cohesity.Private.Model;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of views filtered by specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all views on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// <para type="description">
    /// NOTE: If MaxCount is specified and the number of views returned exceeds the MaxCount, there are more views to return.
    /// To get the next set of views, send another request and specify the id of the
    /// last view returned in ViewList from the previous response.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityExampleCSharp
    ///   </code>
    ///   <para>
    ///   Displays the view with the name "Test-view".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityExampleCSharp")]
    [OutputType(typeof(Model.View))]
    public class GetCohesityExampleCSharp : PSCmdlet
    {
        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            MyView myView = new MyView();
            WriteObject(myView, true);
        }
    }
}
