"use strict";
$inject = ["$http"];
angular.module("angular").service("angularWithTS.Services.PlayListService", PlayListService);
angular
    .module('RabbitApp')
    .service('dataservice', dataservice);
dataservice.$inject = ['$http'];
var GalleriesService = (function () {
    function GalleriesService() {
    }
    GalleriesService.prototype.getMyGalleries = function () {
        return;
    };
    return GalleriesService;
}());
exports.GalleriesService = GalleriesService;
RabbitApp.add;
