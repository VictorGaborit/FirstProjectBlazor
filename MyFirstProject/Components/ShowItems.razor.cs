﻿using Microsoft.AspNetCore.Components;

namespace MyFirstProject.Components
{
    public partial class ShowItems<TItem>
    {
        [Parameter]
        public List<TItem> Items { get; set; }

        [Parameter]
        public RenderFragment<TItem> ShowTemplate { get; set; }
    }
}
