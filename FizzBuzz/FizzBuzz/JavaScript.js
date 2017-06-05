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
        console.log("Getting address");
        return privateDetails.address;
    };

    var setAddress = function (address) {
        privateDetails.address = address;
        getAddress();
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
        setAddress, setAddress,
        getFive: getFive,
        setFive: setFive
    }

})("Pieter");

var Zone = {
    run: function (callback) {
        if (this.beforeTask) {
            this.beforeTask();
        }

        //console.log("BEFORE");
        callback();
        //console.log("AFTER");

        if (this.afterTask) {
            this.afterTask();
        }
    }
}
Zone.beforeTask = () => { console.log("BEFORE TASK"); }
Zone.afterTask = () => { console.log("AFTER TASK"); }
Zone.run(() => { console.log("Hallo World"); });
Person.setAddress("BOOM!!!");
