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
    public class ColumnTests : BunitTest
    {
        class TestColumn : Column<object>
        {
            protected internal override object CellContent(object item) => null;
            protected internal override object PropertyFunc(object item) => null;
            protected internal override void SetProperty(object item, object value) { }
            protected internal override Type PropertyType => typeof(object);
        }

        [Test]
        public void ColumnDefaultIconsTest()
        {
            var sortIcon = Icons.Material.Filled.ArrowUpward;
            var filterIcon = Icons.Material.Outlined.FilterAlt;
            var filterAppliedIcon = Icons.Material.Filled.FilterAlt;

            var comp = Context.RenderComponent<TestColumn>();
            comp.Instance.SortIcon.Should().Be(sortIcon);
            comp.Instance.FilterIcon.Should().Be(filterIcon);
            comp.Instance.FilterAppliedIcon.Should().Be(filterAppliedIcon);
        }
    }
}
