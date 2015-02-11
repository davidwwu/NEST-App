﻿var colors = ['#1E90FF', '#FF1493', '#32CD32', '#FF8C00', '#4B0082'];

var noPOIs = [
    {
        featureType: "poi",
        elementType: "labels",
        stylers: [
              { visibility: "off" }
        ]
    }
];

var mapOptions = {
    zoom: 18,
    center: new google.maps.LatLng(34.2417, -118.529),
    disableDefaultUI: true,
    zoomControl: true,
    mapTypeId: google.maps.MapTypeId.ROADMAP,
    disableDoubleClickZoom: true,
    styles: noPOIs,
}

var polyOptions = { //Options set for the polygon shapes and drawing manager
    strokeWeight: 0,
    fillOpacity: 0.45,
    editable: true
};
var uavTrails = [{
    id: 0,
    trail: []
}];

var uavSymbolBlack = {
    path: 'M 355.5,212.5 513,312.25 486.156,345.5 404.75,315.5 355.5,329.5 308.25,315.5 224.75,345.5 197.75,313 z',
    fillColor: 'black',
    fillOpacity: 0.8,
    scale: 0.2,
    zIndex: 1,
    anchor: new google.maps.Point(355, 295)
};

var uavCircleBlack = {
    path: google.maps.SymbolPath.CIRCLE,
    fillColor: 'black',
    scale: 30,
    strokeWeight: 4,
    zIndex: -1
};

var uavSymbolGreen = {
    path: 'M 355.5,212.5 513,312.25 486.156,345.5 404.75,315.5 355.5,329.5 308.25,315.5 224.75,345.5 197.75,313 z',
    fillColor: 'green',
    fillOpacity: 0.8,
    scale: 0.2,
    zIndex: 1,
    anchor: new google.maps.Point(355, 295)
};
var mapClickIcon = {
    url: '../Content/img/markerBLUE.png',
    scaledSize: new google.maps.Size(35, 60)
};
var goldStarBase = {
    path: 'M 125,5 155,90 245,90 175,145 200,230 125,180 50,230 75,145 5,90 95,90 z',
    fillColor: 'yellow',
    fillOpacity: 0.8,
    scale: 0.3,
    strokeColor: 'gold',
    strokeWeight: 4,
    anchor: new google.maps.Point(90, 140)
};

function BaseControl(controlDiv, map) {
    controlDiv.style.padding = '6px';

    //CSS for control button exterior
    var controlUI = document.createElement('div');
    controlUI.style.backgroundColor = 'white';
    controlUI.style.borderStyle = 'solid';
    controlUI.style.borderWidth = '1px';
    controlUI.style.width = '53px';
    controlUI.style.cursor = 'pointer';
    controlUI.style.textAlign = 'center';
    controlUI.title = "Zoom to base";
    controlDiv.appendChild(controlUI);

    //CSS for control button interior
    var controlText = document.createElement('div');
    controlText.style.fontFamily = 'Arial,sans-serif';
    controlText.style.fontSize = '11px';
    controlText.style.paddingLeft = '4px';
    controlText.style.paddingRight = '4px';
    controlText.style.paddingTop = '2px';
    controlText.style.paddingBottom = '4px';
    controlText.innerHTML = 'Base';
    controlUI.appendChild(controlText);

    //Click event listener
    google.maps.event.addDomListener(controlUI, 'click', function () {
        map.setCenter(homeBase);
        map.setZoom(18);
    });
}

var message = $("#infobox").attr("msg");
var infobox = new InfoBox({
    content: document.getElementById("infobox"),
    disableAutoPan: false,
    maxWidth: 100,
    pixelOffset: new google.maps.Size(-75, 30),
    zIndex: null,
    boxStyle: {
        opacity: 0.75,
        width: "150px"
    },
    closeBoxMargin: "9px 1px 2px 2px"
});

var infoboxAlert = new InfoBox({
    content: document.getElementById("infoboxAlert"),
    disableAutoPan: false,
    maxWidth: 20,
    pixelOffset: new google.maps.Size(-10, -80),
    zIndex: null,
    boxStyle: {
        opacity: 0.75,
        width: "20px",
    },
});

//setting trail style
var uavTrail = {
    url: '../Content/img/blue.jpg',
    fillOpacity: 0.7,
    size: new google.maps.Size(46, 44),
    scaledSize: new google.maps.Size(5, 5),
    anchor: new google.maps.Point(5, 5)
};