var app = angular.module('myApp', []);
app.service('RabbitSe', function ($http) {
    this.GetAllRabit = function () {
        var resp = $http.get("/api/GetAllRabbit");
        return resp;
    };
});