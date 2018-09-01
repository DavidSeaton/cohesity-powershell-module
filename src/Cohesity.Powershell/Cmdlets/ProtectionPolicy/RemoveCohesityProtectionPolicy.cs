﻿using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionPolicy
{
    /// <summary>
    /// <para type="synopsis">
    /// Removes a protection policy.
    /// </para>
    /// <para type="description">
    /// Returns success if the protection policy is removed.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityProtectionPolicy -Id 7004504288922732:1533243443420:3
    ///   </code>
    ///   <para>
    ///   Removes a protection policy with the Id of "7004504288922732:1533243443420:3".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "CohesityProtectionPolicy")]
    public class RemoveCohesityProtectionPolicy : PSCmdlet
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

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection policy.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty()]
        public string Id { get; set; }

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            // POST /public/protectionPolicies/{id}
            var preparedUrl = $"/public/protectionPolicies/{Id}";
            Session.NetworkClient.Delete(preparedUrl, string.Empty);
            WriteObject("Protection policy was deleted successfully.");
        }

        #endregion
    }
}
