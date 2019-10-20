
var theurl = 'https://localhost:44347/api/weatherforecast';
var listObject = document.querySelector("#list");
var selector = document.querySelector("#selector");

var HttpClient = function () {
    this.get = function (aUrl, aCallback) {
        var anHttpRequest = new XMLHttpRequest();
        anHttpRequest.onreadystatechange = function () {
            if (anHttpRequest.readyState == 4 && anHttpRequest.status == 200)
                aCallback(anHttpRequest.responseText);
        }
        anHttpRequest.open("GET", aUrl, true);
        anHttpRequest.send(null);
    }
}

var client = new HttpClient();
client.get(theurl, function (response) {
    var response1 = JSON.parse(response);
    if (response1 != null) {
        response1.forEach(element => {
            if (!this.selector.innerHTML.includes(element.city))
                this.selector.innerHTML += `<option value=${element.city}>${element.city}</option>`;
            var resultTD = document.createElement("tr");
            resultTD.innerText = `Şehir: ${element.city} , Sıcaklık: ${element.celcius} , Nem: ${element.humidity} , Durum: ${element.status}`
            this.listObject.appendChild(resultTD);
        });
    }
});

var theurl2 = 'https://localhost:44347/api/weatherforecast/GetByCity';

function onChangeEvent() {
    var city = document.querySelector("#selector").value;
    document.querySelector("#header").innerText = city;

    if (city !== null && city !== "") {
        this.client.get(`${theurl2}/${city}`, function (response) {
            var response1 = JSON.parse(response);
            if (response1 !== null) {
                this.listObject.innerHTML = "";
                response1.forEach(element => {
                    var resultTD = document.createElement("tr");
                    resultTD.innerText = `Şehir: ${element.city} , Sıcaklık: ${element.celcius} , Nem: ${element.humidity} , Durum: ${element.status}`
                    this.listObject.appendChild(resultTD);

                });
            }

        });
    }
}
