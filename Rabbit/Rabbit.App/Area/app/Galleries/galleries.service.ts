
namespace app {
    'use strict';

    export class GalleriesService {
        static IID = 'GalleriesService';
        static $inject = ['$http'];
        constructor(public $http: angular.IHttpService) {};

        public GetAllGalleries(): any {
            return this.$http
                .get('/api/GetAllGalleries/');
        }
    }
    angular.module('app')
        .service(GalleriesService.IID, GalleriesService);
}