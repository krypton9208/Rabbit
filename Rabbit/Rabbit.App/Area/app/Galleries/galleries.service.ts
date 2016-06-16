
namespace app {

    GalleriesService.$inject = ['$http'];

    class GalleriesService {

        public name: string = 'Damian';
        constructor() {

        };
}
angular.module("app").service('GalleriesService', GalleriesService);
}