mapboxgl.accessToken = 'pk.eyJ1IjoiZmlyYXRrYWhybW4iLCJhIjoiY2t5NmQyYzFzMHVrdzJ4b25ucDB6MWJwcCJ9.OlPnvC3QnDUefMThdYaQ-A';



const map = new mapboxgl.Map({
    container: 'map',
    style: 'https://api.jsonbin.io/b/612dcff7259bcb6118ef834b',
    zoom: 13,    
    center: [39.75, 41]
});

map.on('load', () => {
    map.addSource('konumlar', {
        type: 'geojson',
        data: 'https://api.jsonbin.io/b/61da07e239a33573b325a852/1'
    });


    map.addLayer({
        'id': 'konumlar',
        'type': 'circle',
        'source': 'konumlar',
        'paint': {
            'circle-color': 'blue',
            'circle-radius': 7,
            'circle-stroke-width': 2,
            'circle-stroke-color': 'white'
        },

    });


    map.on('click', 'konumlar', (e) => {
        const coordinates = e.features[0].geometry.coordinates.slice();
        const description = e.features[0].properties.isim;
        const place = e.features[0].properties.konum;        
        const tur = e.features[0].properties.tur;
        const kalan = e.features[0].properties.indirim;

        popup.setLngLat(coordinates).setHTML(description + "<br>Türü: " + tur + "<br>Konum: " + place + "<br>Kalan İndirim Hakkı: " + kalan).addTo(map);
        
        map.flyTo({
            center: e.features[0].geometry.coordinates
        });
    });
        
    map.on('mouseenter', 'konumlar', () => {
        map.getCanvas().style.cursor = 'pointer';
    });
     
    const popup = new mapboxgl.Popup({
        closeButton: true,
        closeOnClick: true
    });
});

map.addControl(
    new MapboxGeocoder({
        accessToken: mapboxgl.accessToken,
        mapboxgl: mapboxgl
    })
);

map.addControl(new mapboxgl.FullscreenControl());
map.addControl(
    new mapboxgl.GeolocateControl({
        positionOptions: {
            enableHighAccuracy: true
        },
        trackUserLocation: true,
        showUserHeading: true
    })
);

async function setoption() {
    const scale = new mapboxgl.ScaleControl({
        maxWidth: 100,
        unit: 'metric'
    });
    map.addControl(scale);

    scale.setUnit('metric');
}

