﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SlideFlashs.ascx.cs" Inherits="Control_Common_SlideFlashs" %>
<%@ Import Namespace="System.Data" %>
<div id="SlideFlashs" style="position: relative; width: 960px; height: 310px; overflow: hidden;">
    <!-- Loading Screen -->
    <div u="loading" style="position: absolute; top: 0px; left: 0px;">
        <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000000; top: 0px; left: 0px; width: 100%; height: 100%;">
        </div>
        <div style="position: absolute; display: block; background: url(../Images/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
        </div>
    </div>

    <!-- Slides Container -->
    <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 960px; height: 310px; overflow: hidden;">
         <% foreach (DataRow row in Flash.Rows)
                   {
                       string link = row["Link"].ToString().Trim() == "" ? "javascript:void();" : row["Link"].ToString();
                %>
        <div>
            <a href="<%= link%>"><img  alt="idefloors.vn"  u="image" src="../Images/Flash/<%= row["ImgUrl"].ToString()%>" /></a>
            <img  alt="idefloors.vn"  u="thumb" src="../Images/Flash/<%= row["ThumbUrl"].ToString()%>" />
        </div>
        <%} %>
    </div>

    <!--#region Arrow Navigator Skin Begin -->
    <style>
        /* jssor slider arrow navigator skin 05 css */
        /*
            .jssora05l                  (normal)
            .jssora05r                  (normal)
            .jssora05l:hover            (normal mouseover)
            .jssora05r:hover            (normal mouseover)
            .jssora05l.jssora05ldn      (mousedown)
            .jssora05r.jssora05rdn      (mousedown)
            */
        .jssora05l, .jssora05r {
            display: block;
            position: absolute;
            /* size of arrow element */
            width: 40px;
            height: 40px;
            cursor: pointer;
            background: url(../Images/a21.png) no-repeat;
            overflow: hidden;
        }

        .jssora05l {
            background-position: -10px -40px;
        }

        .jssora05r {
            background-position: -70px -40px;
        }

        .jssora05l:hover {
            background-position: -130px -40px;
        }

        .jssora05r:hover {
            background-position: -190px -40px;
        }

        .jssora05l.jssora05ldn {
            background-position: -250px -40px;
        }

        .jssora05r.jssora05rdn {
            background-position: -310px -40px;
        }
    </style>
    <!-- Arrow Left -->
    <span u="arrowleft" class="jssora05l" style="top: 106px; left: 8px;"></span>
    <!-- Arrow Right -->
    <span u="arrowright" class="jssora05r" style="top: 106px; right: 8px"></span>
    <!--#endregion Arrow Navigator Skin End -->
    <!--#region Thumbnail Navigator Skin Begin -->
    <style>
        /* jssor slider thumbnail navigator skin 01 css */
        /*
            .jssort01 .p            (normal)
            .jssort01 .p:hover      (normal mouseover)jssort01
            .jssort01 .p.pav        (active)
            .jssort01 .p.pdn        (mousedown)
            */
        .jssort01 {
            position: absolute;
            /* size of thumbnail navigator container */
            width: 960px;
            height: 45px;
            /*display:none;
            border:1px solid red;*/
        }

            .jssort01 .p {
                position: absolute;
                top: 0;
                left: 0;
                width: 40px;
                height: 40px;
            }

            .jssort01 .t {
                position: absolute;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                border: none;
            }

            .jssort01 .w {
                position: absolute;
                top: 0px;
                left: 0px;
                width: 100%;
                height: 100%;
            }

            .jssort01 .c {
                position: absolute;
                top: 0px;
                left: 0px;
                width: 36px;
                height: 36px;
                border: #000 2px solid;
                box-sizing: content-box;
                background: url(../Images/t01.png) -800px -800px no-repeat;
                _background: none;
            }

            .jssort01 .pav .c {
                top: 2px;
                _top: 0px;
                left: 2px;
                _left: 0px;
                width: 36px;
                height: 36px;
                border: #000 0px solid;
                _border: #fff 2px solid;
                background-position: 50% 50%;
            }

            .jssort01 .p:hover .c {
                top: 0px;
                left: 0px;
                width: 38px;
                height: 38px;
                border: #fff 1px solid;
                background-position: 50% 50%;
            }

            .jssort01 .p.pdn .c {
                background-position: 50% 50%;
                width: 36px;
                height: 36px;
                border: #000 2px solid;
            }

            * html .jssort01 .c, * html .jssort01 .pdn .c, * html .jssort01 .pav .c {
                /* ie quirks mode adjust */
                width /**/: 72px;
                height /**/: 72px;
            }
    </style>

    <!-- thumbnail navigator container -->
    <div u="thumbnavigator" class="jssort01" style="left: 0px; bottom: 0px;">
        <!-- Thumbnail Item Skin Begin -->
        <div u="slides" style="cursor: default;">
            <div u="prototype" class="p">
                <div class="w">
                    <div u="thumbnailtemplate" class="t"></div>
                </div>
                <div class="c"></div>
            </div>
        </div>
        <!-- Thumbnail Item Skin End -->
    </div>
    <!--#endregion Thumbnail Navigator Skin End -->
</div>
