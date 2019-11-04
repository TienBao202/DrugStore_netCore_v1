/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.medicine_batch', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('medicine_batch', {
            url: "/medicine_batch",
            templateUrl: "/app/components/medicine_batch/medicine_batchListView.html",
            controller: "medicine_batchListController"
        }).state('medicine_batch_add', {
            url: "/medicine_batch_add",
            templateUrl: "/app/components/medicine_batch/medicine_batchAddView.html",
            controller: "medicine_batchAddController"
            }).state('medicine_batch_edit', {
            url: "/medicine_batch_edit/:id",
            templateUrl: "/app/components/medicine_batch/medicine_batchEditView.html",
            controller: "medicine_batchEditController"
        });
    }
})();