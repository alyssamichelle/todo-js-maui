var jsMethods = {};

jsMethods.checkNumber = function () {
    const number = prompt("Enter a number:");
    DotNet.invokeMethodAsync("MauiAngularInterop", "CheckNumber", parseInt(number))
        .then(result => {
            alert(result);
        });
}

jsMethods.grabDeviceInfo = function () {
    DotNet.invokeMethodAsync("MauiAngularInterop", "GetDeviceInfo")
        .then(result => {
            var el = document.getElementById("device-result");
            el.innerHTML = result;
        });
}

