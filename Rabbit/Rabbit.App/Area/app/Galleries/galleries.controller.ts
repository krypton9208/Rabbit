namespace app {
    'use strict';

    class GalleriesController {
        static $inject: Array<string> = ['GalleriesService'];
         
        constructor(public GalleriesService: any)
        {
        }

        public GetMyGalleries(): string{
            return this.GalleriesService.Name;
        }

    }
    angular.module('app')
        .controller('GalleriesController', GalleriesController);

}