<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Contact.ascx.cs" Inherits="Control_Contact" %>
<div class="L_col">
    <div>
        <h2>Liên hệ:</h2>
    </div>
    <br />
    <br />
    <div id="contact">
        <div class="title">CÔNG TY TNHH MỸ NGHỆ - NỘI THẤT HIỆP PHÁT</div>
        <div class="desc"><b>Địa chỉ:</b> 1494/13/11A Quốc Lộ 1A, Phường Tân Thới Hiệp, Quận 12, HCM</div>
        <div class="desc"><b>VPĐD:</b> 58A đường 77, phường Tân Quy, Quận 7, Hồ Chí Minh.</div>
        <div class="desc"><b>Điện thoại:</b> 08.66795275</div>
        <div class="desc"><b>Fax:</b> 08.62621387</div>
        <div class="desc"><b>MST:</b> 0313050880</div>
        <div class="desc"><b>Số TK:</b> 0181003445661 tại Ngân Hàng Vietcombank - CN Nam Sài Gòn.</div>
    </div>
</div>

<div class="R_col">
    <div>
        <h2>Bản đồ:</h2>
    </div>
    <br />
    <br />
    <div id="map-canvas" style='width: 280px; height: 210px'>
    </div>
</div>

<script src="http://maps.googleapis.com/maps/api/js?key=AIzaSyAOSyDOhFlz6Oz8FgyQ_ATMyzvq-OACW6A&sensor=false"></script>
<script>
    var address = 'Số 77, Tân Quy, Quận 7, Hồ Chí Minh';

    function initialize() {
        var myLatlng = new google.maps.LatLng(0, 0);
        var mapOptions = {
            zoom: 17,
            center: myLatlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        var map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions); 
            
            var geocoder = new google.maps.Geocoder();
            geocoder.geocode({ 'address': address }, function (results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    var contentString = '<div id="content">' +
                                  '<div id="siteNotice">' +
                                  '</div>' +
                                  '<div id="bodyContent">' +
                                  '<p>58A đường 77, phường Tân Quy, Quận 7, Hồ Chí Minh</p>' +
                                  '</div>' +
                                  '</div>';
                    
                    var infowindow = new google.maps.InfoWindow({
                        content: contentString
                    });
                    //In this case it creates a marker, but you can get the lat and lng from the location.LatLng
                    map.setCenter(results[0].geometry.location);
                    var marker = new google.maps.Marker({
                        map: map,
                        position: results[0].geometry.location,
                        title: address,
                    });
                    google.maps.event.addListener(marker, 'click', function () {
                        infowindow.open(map, marker);
                    });
                } else {
                    alert("Geocode was not successful for the following reason: " + status);
                }
            });
    }

    google.maps.event.addDomListener(window, 'load', initialize);
</script>
