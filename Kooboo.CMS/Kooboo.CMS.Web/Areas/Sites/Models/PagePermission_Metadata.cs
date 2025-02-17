﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.CMS.Sites.Models;
using Kooboo.CMS.Web.Areas.Sites.Models.DataSources;
using Kooboo.ComponentModel;
using Kooboo.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Kooboo.CMS.Web.Areas.Sites.Models
{
    [MetadataFor(typeof(PagePermission))]
    public class PagePermission_Metadata
    {
        [DisplayName("Require Authentication")]
        public bool RequireAuthentication { get; set; }

        [DisplayName("Allow roles")]
        [UIHint("Multiple_DropDownList")]
        [DataSource(typeof(RolesDatasource))]    
        public string[] AllowRoles { get; set; }

        [DisplayName("Authorize menu")]
        public bool AuthorizeMenu { get; set; }

        [DisplayName("Unauthorized URL")]
        [UIHint("AutoComplete")]
        [DataSource(typeof(AutoCompletePageListDataSouce))]
        public string UnauthorizedUrl { get; set; }
    }
}
