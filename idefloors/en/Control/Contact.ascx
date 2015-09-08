<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Contact.ascx.cs" Inherits="Control_Contact" %>
<div class="">
    <div>
        <h2>Contact:</h2>
    </div>
    <br />
    <br />
    <div id="contact">
        <div class="title">HIEP PHAT IMPORT EXPORT SERVICE TRADING INVESTMENT COMPANY LIMITED</div>
        <div class="desc"><b>Address:</b> No 1494/13/11A, Highway 1A, Tan Thoi  Hiep Ward, District 12, Hochiminh City,Vietnam</div>
        <div class="desc"><b>Representative Office:</b> 1472 Bui Ta Han Street,  An Phu Ward, District 2, Hochiminh City,Vietnam</div>
        <div class="desc"><b>Tel:</b> 08.6679 5275</div>
        <div class="desc"><b>Mobile:</b> +(84) 917 703 997 (Mr Pham)</div>
        <div class="desc"><b>Fax:</b> 08.6262 1387</div> 
        <div class="desc"><b>Site:</b> <a href="http://hiepphatcorp.com">www.hiepphatcorp.com</a></div> 
    </div>
</div>

<br />
<br />
<div style="text-align:center;">
    <div style="text-align:left !important;">
        <h2>Map:</h2>
    </div>
    <br />
    <br />
    <div id="map-canvas" style='width: 726px; height: 400px'>
    </div>
</div>

<script src="http://maps.googleapis.com/maps/api/js?key=AIzaSyAOSyDOhFlz6Oz8FgyQ_ATMyzvq-OACW6A&sensor=false"></script>
<script>
    var address = '1494/13/11A đường Tân Thới Hiệp 7, phường Tân Thới Hiệp, quận 12, Hồ Chí Minh, Việt Nam';

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
                                  '<p>No 1494/13/11A, Highway 1A, Tan Thoi  Hiep Ward, District 12, Hochiminh City,Vietnam</p>' +
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
