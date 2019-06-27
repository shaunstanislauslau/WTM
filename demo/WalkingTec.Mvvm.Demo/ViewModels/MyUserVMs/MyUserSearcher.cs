﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;

namespace WalkingTec.Mvvm.Demo.ViewModels.MyUserVMs
{
    public class MyUserSearcher : BaseSearcher
    {
        [Display(Name = "账号")]
        public string ITCode { get; set; }

        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        public SexEnum? Sex { get; set; }

        [Display(Name = "是否有效")]
        public new bool? IsValid { get; set; }

        public List<ComboSelectListItem> AllUserRoless { get; set; }

        [Display(Name = "角色")]
        public List<Guid> SelectedUserRolesIDs { get; set; }

        protected override void InitVM()
        {
            AllUserRoless = DC.Set<FrameworkRole>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.RoleName);
        }

    }
}
