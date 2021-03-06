﻿namespace RongCloudNetCore.Models
{
    /// <summary>
    /// http 成功返回结果
    /// </summary>
    public class CodeSuccessReslut : BaseModel
    {
        public CodeSuccessReslut(int code, string errorMessage)
        {
            Code = code;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// 返回码，200正常
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
