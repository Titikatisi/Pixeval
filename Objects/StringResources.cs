﻿// Pixeval - A Strong, Fast and Flexible Pixiv Client
// Copyright (C) 2019 Dylech30th
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

namespace Pixeval.Objects
{
    public static class StringResources
    {
        public const string EmailOrPasswordIsWrong = "用户名或密码错误";

        public const string EmptyEmailOrPasswordIsNotAllowed = "用户名或密码不能为空";

        public const string IdDoNotExists = "您所输入的ID不存在, 请检查后再试一次吧~";

        public const string CannotFindUser = "抱歉, Pixeval找不到您搜索的用户呢, 请仔细检查用户ID后再来一次吧~";

        public const string InputIsEmpty = "请在输入搜索关键字后再进行搜索~";

        public const string QueryNotResponding = "抱歉, Pixeval无法根据当前的设置找到任何作品, 或许是您的页码设置过大/关键字不存在/没有收藏任何作品, 请检查后再尝试吧~";

        public const string IdIllegal = "搜索ID时必须输入纯数字哟~";

        public const string UserIdIllegal = "搜索用户ID时必须输入纯数字哟~";

        public const string AppApiAuthenticateTimeout = "AppApi登录请求超时, 请仔细检查您的网络环境";

        public const string WebApiAuthenticateTimeout = "WebApi登录请求超时, 请仔细检查您的网络环境";

        public const string MultiplePixevalInstanceDetected = "已经有一个Pixeval实例在运行了";

        public const string MultiplePixevalInstanceDetectedTitle = "不能同时运行两个Pixeval实例!";

        public const string CppRedistributableRequired = "Pixeval运行需要Visual C++ Redistributable 2015/2017/2019 x64支持, 否则部分功能将会受到影响, 请前往https://support.microsoft.com/zh-cn/help/2977003/the-latest-supported-visual-c-downloads下载最新的Visual C++ Redistributable, 链接已经复制到剪切板";

        public const string CppRedistributableRequiredTitle = "未检测到版本大于2015的64位VC++ Redistributable";

        public const string CertificateInstallationIsRequired = "检测到本机尚未安装证书, 若不安装该证书则会导致WebApi登录无法使用, 接下来将会执行安装证书进程, 过程中也许会有弹窗, 请点击确定/OK, 该证书私钥将不会被泄露和分发";

        public const string CertificateInstallationIsRequiredTitle = "安装根证书";
    }
}