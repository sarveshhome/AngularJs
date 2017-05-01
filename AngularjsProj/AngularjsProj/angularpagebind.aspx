<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="angularpagebind.aspx.cs" Inherits="AngularjsProj.angularpagebind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="app">
<head runat="server">
    <title></title>
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/Controller/app.js"></script>
    <script src="Scripts/Controller/config.js"></script>
    <script src="Scripts/Controller/controller.js"></script>
    <script src="Scripts/Controller/Service.js"></script>
</head>
<body ng-controller="pageBindCtrl">
    <form id="f" runat="server">
       <table border="0">
            <tr>
                <td>
                    <table>
                        <tr>
                            <th>Sr. No.</th>
                            <th>Book Title</th>
                            <th>Author</th>
                            <th>Price</th>
                        </tr>
                        <tr ng-repeat="book in returnData | orderBy : 'title'">
                            <td>{{$index +1}} </td>
                            <td>{{ book.title }}</td>
                            <td>{{ book.author }}</td>
                            <td>{{ book.price }}</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
