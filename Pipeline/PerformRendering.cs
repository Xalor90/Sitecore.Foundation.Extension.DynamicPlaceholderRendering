using Sitecore.Mvc.Pipelines.Response.RenderPlaceholder;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sitecore.Foundation.Extension.DynamicPlaceholderRendering.Pipeline
{
    public class PerformRendering : Mvc.Pipelines.Response.RenderPlaceholder.PerformRendering
    {
        protected override void Render(string placeholderName, TextWriter writer, RenderPlaceholderArgs args)
        {
            var renderingsForPlaceholder = GetRenderings(placeholderName, args).ToList();
            if (!renderingsForPlaceholder.Any())
            {
                var unusedPlaceholders = Context.Items["unusedPlaceholderKeys"] as List<string> ?? new List<string>();
                unusedPlaceholders.Add(placeholderName);
                Context.Items["unusedPlaceholderKeys"] = unusedPlaceholders;
            }

            foreach (Rendering rendering in renderingsForPlaceholder)
            {
                if (rendering != null)
                {
                    using (CreateCyclePreventer(placeholderName, rendering))
                    {
                        ProcessRenderRendering(rendering, writer);
                    }
                }
            }
        }
    }
}