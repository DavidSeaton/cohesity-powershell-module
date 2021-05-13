function Get-CohesityExampleScript {
    <#
        .SYNOPSIS
        Get allowlist IP(s) for a given view.
        .DESCRIPTION
        Get allowlist IP(s) for a given view.
        .NOTES
        Published by Cohesity
        .LINK
        https://cohesity.github.io/cohesity-powershell-module/#/README
        .EXAMPLE
        Get-CohesityExampleScript
    #>

    [OutputType('Cohesity.Private.Model.MyView')]
    [CmdletBinding()]
    Param(
    )

    Begin {
    }

    Process {
		$resp = [Cohesity.Private.Model.MyView]::new()
        #@($resp | Add-Member -TypeName 'Cohesity.Private.Model.MyView' -PassThru)
		$resp
    }

    End {
    }
}