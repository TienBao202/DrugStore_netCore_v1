/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.medicine_unit', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('medicine_unit_add', {
            url: "/medicine_unit_add",
            templateUrl: "/app/components/medicine_unit/medicine_unitAddView.html",
            controller: "medicine_unitAddController"
            });
    }
})();