var Person = (function (names) {

    var publicDetails = {
        name: names,
        surname: "Engelbrecht"
    };

    var privateDetails = {
        address: "Jean Ave",
        phone: "01267"
    }

    var x = "5";

    var getName = function () {
        return publicDetails.name;
    };

    var setSurname = function (surname) {
        publicDetails.surname = surname;
    };

    var getSurname = function () {
        return publicDetails.surname;
    };

    var getAddress = function () {
        return privateDetails.address;
    };

    var setAddress = function (address) {
        privateDetails.address = address;
    };

    var getFive = function () {
        return x;
    };

    var setFive = function (y) {
        x = y;
    };
    return {
        getName: getName,
        setSurname: setSurname,
        getSurname: getSurname,
        publicDetails: publicDetails,
        getAddress: getAddress,
        setAddress, setAddress,
        getFive: getFive,
        setFive: setFive
    }

})("Pieter");