/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.medicine_category', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('medicine_category', {
            url: "/medicine_category",
            templateUrl: "/app/components/medicine_category/medicine_categoryListView.html",
            controller: "medicine_categoryListController"
        }).state('medicine_category_add', {
            url: "/medicine_category_add",
            templateUrl: "/app/components/medicine_category/medicine_categoryAddView.html",
            controller: "medicine_categoryAddController"
            }).state('medicine_category_edit', {
            url: "/medicine_category_edit/:id",
            templateUrl: "/app/components/medicine_category/medicine_categoryEditView.html",
            controller: "medicine_categoryEditController"
        });
    }
})();