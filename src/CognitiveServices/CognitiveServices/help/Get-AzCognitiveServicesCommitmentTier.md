---
external help file: Microsoft.Azure.PowerShell.Cmdlets.CognitiveServices.dll-Help.xml
Module Name: Az.CognitiveServices
online version: https://learn.microsoft.com/powershell/module/az.cognitiveservices/get-azcognitiveservicescommitmenttier
schema: 2.0.0
---

# Get-AzCognitiveServicesCommitmentTier

## SYNOPSIS
Get CommitmentTier of Cognitive Services

## SYNTAX

```
Get-AzCognitiveServicesCommitmentTier [-Location] <String> [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

## DESCRIPTION
Get CommitmentTier of Cognitive Services

## EXAMPLES

### Example 1
```powershell
Get-AzCognitiveServicesCommitmentTier -Location 'WestUS'
```

```output
Kind         : kind
SkuName      : sku
HostingModel : hosting model
PlanType     : plan type
Tier         : tier
MaxCount     : 
Quota        : Microsoft.Azure.Management.CognitiveServices.Models.CommitmentQuota
Cost         : Microsoft.Azure.Management.CognitiveServices.Models.CommitmentCost
```

Get CommitmentTier of Cognitive Services

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
Cognitive Services Account Location.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Management.CognitiveServices.Models.CommitmentTier

## NOTES

## RELATED LINKS
