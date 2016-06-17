namespace app {
    'use strict';
    class GalleriesController {
        static IID = 'GalleriesController';
        static $inject = [GalleriesService.IID];
        public siema: string;

        constructor(service: GalleriesService, info: string) {
            this.siema = info;
        }
        
        public GetInfo() {
            return this.siema;
            this.GalleriesService.ge
        }
    }
    angular.module('app')
        .controller('GalleriesController', GalleriesController);
}