<%@ Control Language="C#" AutoEventWireup="true" CodeFile="L_Frame_5.ascx.cs" Inherits="Control_ReferenceFrames_L_Frame_001" %>
<div id="Slide_L_Frame_5" style="position: relative; width: 435px; height: 210px; overflow: hidden;">
    <!-- Loading Screen -->
    <div u="loading" style="position: absolute; top: 0px; left: 0px;">
        <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000000; top: 0px; left: 0px; width: 100%; height: 100%;">
        </div>
        <div style="position: absolute; display: block; background: url(../Images/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
        </div>
    </div>

    <!-- Slides Container -->
    <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 435px; height: 210px; overflow: hidden;">
        <div>
            <img u="image" src="../Images/References/Hotel/01.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-01.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/02.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-02.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/03.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-03.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/04.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-04.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/05.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-05.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/06.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-06.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/07.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-07.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/08.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-08.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/09.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-09.jpg" />
        </div>
        <div>
            <img u="image" src="../Images/References/Hotel/10.jpg" />
            <img u="thumb" src="../Images/References/Hotel/thumb-10.jpg" />
        </div>
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
        .L_col .jssora05l, .L_col .jssora05r {
            display: block;
            position: absolute;
            /* size of arrow element */
            width: 40px;
            height: 40px;
            cursor: pointer;
            background: url(../Images/a22.png) no-repeat;
            overflow: hidden;
        }

        .L_col .jssora05l {
            background-position: -10px -40px;
        }

        .L_col .jssora05r {
            background-position: -70px -40px;
        }

        .L_col .jssora05l:hover {
            background-position: -130px -40px;
        }

        .L_col .jssora05r:hover {
            background-position: -190px -40px;
        }

        .L_col .jssora05l.jssora05ldn {
            background-position: -250px -40px;
        }

        .L_col .jssora05r.jssora05rdn {
            background-position: -310px -40px;
        }
    </style>
    <!-- Arrow Left -->
    <span u="arrowleft" class="jssora05l" style="top: 90px; left: 8px;"></span>
    <!-- Arrow Right -->
    <span u="arrowright" class="jssora05r" style="top: 90px; right: 8px"></span>
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
        .L_col .jssort01 {
            position: absolute;
            /* size of thumbnail navigator container */
            width: 435px;
            height: 29px;
            /*display:none;*/
        }

            .L_col .jssort01 .p {
                position: absolute;
                top: 0;
                left: 0;
                width: 25px;
                height: 25px;
            }

            .L_col .jssort01 .t {
                position: absolute;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                border: none;
            }

            .L_col .jssort01 .w {
                position: absolute;
                top: 0px;
                left: 0px;
                width: 100%;
                height: 100%;
            }

            .L_col .jssort01 .c {
                position: absolute;
                top: 0px;
                left: 0px;
                width: 21px;
                height: 21px;
                border: #000 2px solid;
                box-sizing: content-box;
                /*background: url(../Images/t01.png) -800px -800px no-repeat;*/
                _background: none;
            }

            .L_col .jssort01 .pav .c {
                top: 2px;
                _top: 0px;
                left: 2px;
                _left: 0px;
                width: 21px;
                height: 21px;
                border: #000 0px solid;
                _border: #fff 2px solid;
                background-position: 50% 50%;
            }

            .L_col .jssort01 .p:hover .c {
                top: 0px;
                left: 0px;
                width: 23px;
                height: 23px;
                border: #fff 1px solid;
                background-position: 50% 50%;
            }

            .L_col .jssort01 .p.pdn .c {
                background-position: 50% 50%;
                width: 21px;
                height: 21px;
                border: #000 2px solid;
            }

            * html .L_col .jssort01 .c, * html .L_col .jssort01 .pdn .c, * html .L_col .jssort01 .pav .c {
                /* ie quirks mode adjust */
                width /**/: 52px;
                height /**/: 52px;
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
<div class="des_references">Hotel</div>

