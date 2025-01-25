// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MudBlazor.UnitTests.TestComponents.DataGrid;
using NUnit.Framework;

namespace MudBlazor.UnitTests.Components
{
    [TestFixture]
    public class FilterHeaderCellTest : BunitTest
    {
        [Test]
        public void FilterHeaderCellDefaultIconsTest()
        {
            var filterAppliedIcon = Icons.Material.Filled.FilterAlt;
            var clearFilterIcon = Icons.Material.Filled.FilterAltOff;

            var comp = Context.RenderComponent<FilterHeaderCell<object>>();
            comp.Instance.FilterAppliedIcon.Should().Be(filterAppliedIcon);
            comp.Instance.ClearFilterIcon.Should().Be(clearFilterIcon);
        }
    }
}
