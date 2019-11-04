/// <reference path="../lib/angular/angular.js" />

(function () {
    angular.module('drugstore.employees', ['drugstore.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('employees', {
            url: "/employees",
            templateUrl: "/app/components/employees/employeeListView.html",
            controller: "employeeListController"
        })
        .state('employee_add', {
            url: "/employee_add",
            templateUrl: "/app/components/employees/employeeAddView.html",
            controller: "employeeAddController"
        })
        .state('employee_edit', {
            url: "/employee_edit/:id",
            templateUrl: "/app/components/employees/employeeEditView.html",
            controller: "employeeEditController"
        });
    }
})();