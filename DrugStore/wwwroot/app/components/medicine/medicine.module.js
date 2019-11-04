/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.medicine', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('medicine', {
            url: "/medicine",
            templateUrl: "/app/components/medicine/medicineListView.html",
            controller: "medicineListController"
        }).state('medicine_add', {
            url: "/medicine_add",
            templateUrl: "/app/components/medicine/medicineAddView.html",
            controller: "medicineAddController"
            }).state('medicine_edit', {
                url: "/medicine_edit/:id",
                templateUrl: "/app/components/medicine/medicineEditView.html",
                controller: "medicineEditController"
        });
    }
})();