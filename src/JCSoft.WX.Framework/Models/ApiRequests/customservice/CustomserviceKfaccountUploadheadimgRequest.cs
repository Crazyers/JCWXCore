﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCSoft.WX.Framework.Models.ApiResponses;
using JCSoft.Core.Net.Http;

namespace JCSoft.WX.Framework.Models.ApiRequests
{
    public class CustomserviceKfaccountUploadheadimgRequest : ApiRequest<MerchantCategoryGetskuResponse>
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 完整客服账号，格式为：账号前缀@公众号微信号
        /// </summary>
        [JsonProperty("kf_account")]
        public string Account { get; set; }

        internal override HttpRequestActionType Method
        {
            get { return HttpRequestActionType.File; }
        }

        protected override string UrlFormat
        {
            get { return "https://api.weixin.qq.com/customservice/kfacount/uploadheadimg?access_token={0}&kf_account={1}"; }
        }

        internal override string GetUrl()
        {
            return String.Format(UrlFormat, AccessToken, Account);
        }

        protected override bool NeedToken
        {
            get { return true; }
        }

        internal override string GetPostContent()
        {
            return this.FilePath;
        }
    }
}
