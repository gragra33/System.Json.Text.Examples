// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using System.Collections.Generic;
using WpfUserAgent.Models;

namespace WpfUserAgent.Extensions;

public static class ReportExtensions
{
    public static IReportData GetPlugins(this UserAgentModel model, string prop)
    {
        ReportLineModel reportLine = new()
        {
            Value = prop,
            Items = new()
        };

        for (int i = 0; i < model.Plugins!.Count; i++)
        {
            PluginModel plugin = model.Plugins![i];

            ReportLineModel line = new()
            {
                Value = plugin.Id,
                Items = new()
            };

            reportLine.Items.Add(line);

            foreach (PluginObjectModel pluginValue in plugin.Values!)
            {
                line.Items.Add(new ReportLineItemModel
                {
                    Key = pluginValue.Id,
                    Value = pluginValue.Value?.ToString() ?? "[Null]"
                });
            }
        }
 
        return reportLine;
    }

    public static IReportData GetUserAgentData(this UserAgentModel model, string prop)
    {
        ReportLineModel reportLine = new()
        {
            Value = prop,
            Items = new List<IReportData>()
        };

        reportLine.Items.Add(new ReportLineItemModel
        {
            Key = "Mobile",
            Value = model.UserAgentData!.Mobile?.ToString() ?? string.Empty
        });

        reportLine.Items.Add(new ReportLineItemModel
        {
            Key = "Platform",
            Value = model.UserAgentData!.Platform?.ToString() ?? string.Empty
        });

        List<BrandModel>? brands = model.UserAgentData!.Brands;

        if (brands is not null)
        {
            ReportLineModel line = new()
            {
                Value = prop,
                Items = new()
            };

            reportLine.Items.Add(line);

            for (var index = 0; index < brands.Count; index++)
            {
                BrandModel item = brands[index];
                line.Items.Add(new ReportLineModel
                {
                    Value = index.ToString(),
                    Items = new List<IReportData>
                    {
                        new ReportLineItemModel { Key = "Brand", Value = item.brand },
                        new ReportLineItemModel { Key = "Version", Value = item.version }
                    }
                });
            }
        }
  
        return reportLine;
    }

    public static IReportData GetLanguage(this UserAgentModel model, string prop)
    {
        ReportLineModel reportLine = new()
        {
            Value = prop,
            Items = new()
        };

        if (model.Languages is not null)
        {
            for (var index = 0; index < model.Languages.Length; index++)
            {
                string language = model.Languages[index];
                reportLine.Items.Add(new ReportLineItemModel
                {
                    Key = index.ToString(),
                    Value = language,
                });
            } 
        }

        return reportLine;
    }
}