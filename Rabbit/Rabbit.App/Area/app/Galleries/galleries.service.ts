
namespace app {
    'use strict';

    class GalleriesService {
        static IID = 'GalleriesService';
        static $inject = ['$http'];

        private info: string = 'Working';
        public name: string = 'Damian';

        constructor(public $http: angular.IHttpService) { };


        public GetInfo(): string {
            return this.info;
        };

        public getMyGalleries(myId: string): angular.IPromise<any> {
            return this.$http({
                method: 'get',
                url: `api/MyGalleries/${myId}`
            }).then((result: { data: any }) => result.data);
        }

    }
    angular.module('app')
        .service('GalleriesService', GalleriesService);
}