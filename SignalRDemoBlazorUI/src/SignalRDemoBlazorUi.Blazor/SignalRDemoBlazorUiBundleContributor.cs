﻿using Volo.Abp.Bundling;

namespace SignalRDemoBlazorUi.Blazor;

/* Add your global styles/scripts here.
 * See https://abp.io/docs/latest/UI/Blazor/Global-Scripts-Styles to learn how to use it
 */
public class SignalRDemoBlazorUiBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
