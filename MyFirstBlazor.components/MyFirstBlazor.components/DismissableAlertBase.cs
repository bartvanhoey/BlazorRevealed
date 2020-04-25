﻿using System;
using Microsoft.AspNetCore.Components;

namespace MyFirstBlazor.components
{
    public class DismissableAlertBase : ComponentBase
    {
        private bool _show = true;

        [Parameter]
        public bool Show
        {
            get => _show;
            set
            {
                if (_show != value)
                {
                    _show = value;
                    ShowChanged?.Invoke(Show);
                }
            }
        }

        [Parameter]
        public Action<bool> ShowChanged { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public void Dismiss()
        {
            Console.WriteLine("Dismissing alert");
            Show = false;
        }
    }
}
