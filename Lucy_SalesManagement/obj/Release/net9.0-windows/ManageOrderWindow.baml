   M S B A M L   `   `   `  ����   Lucy_SalesManagement,    &Lucy_SalesManagement.ManageOrderWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Create & View Orders�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=�$
��1000��$	��716�����#F5F7FA � 	Resources 3  -System.Windows.Media.Effects.DropShadowEffect   ButtonNormalShadow   Color   
BlurRadius   ShadowDepth   Opacity  ButtonHoverShadow  	NavButton �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  
InputStyle ��Name  PrimaryButton �� BasedOn ��Name J� Effect �� 
TargetName��%�  &	        &	 /     &	 _     &	 �    &	 �    7  7   7  7     $ 	#44000000��$ 8Q�$ 2Q�$	 0.5Q�  $ 	#66000000��$ 16Q�$ 4Q�$	 0.8Q��� " ��.��� 	 � ��

 ���� �� 	 � ��

 ������� 	 � ��$	
 8,4q��� 	 � ��$
 SemiBold"��� 	 �@�Cursor$

 Hand���� 	 � ��$
 0q��� 	 � ��
 �� " ��.R��� #��z��$ 4��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �	#44FFFFFF�� " ��.��� 	 � ��$
 0,4,0,4q��� 	 � ��$
 24���� 	 � ��$
 14(��� 	 � ��$
 4q��� 	 � ��
 �#CCC�� 	 � ��

 ������� 	 � ��$
 1q��� 	 � ��
 �� " ��.R��� #��z��#��z��#��z��$ 4��._��� $ PART_ContentHost��$��0q��� " ��8   .��� 	 � ��
 �#2C3E50�� 	 � ��

 ������� 	 � ��$
 14(��� 	 � ��$	
 8,4q��� 	 � ��$
 32���� 	 � ��$
 4q��� 	 �@J�Effect8
  �� 	 � ��
 �� " ��.R��� $ border��#��z��$ 4��# z ._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� $ border��8
  	 �@J�EffectP�  � ��$
 True��. ��� $ border��8
  	 �@J�Effect.��]� .+�� $	��Top=�$��60�����#2C3E50 � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $��LucySale��$��Center=�$��24,0,0,0q�$��24(�$
��Bold"�
��������� -   $��1��$��Logout��#��[ $��0,0,24,0q�$��Center=��� $	��Top=�
������� �� Padding$ 16,12q����#EEE$��0,0,0,1q�._��� $��Create & View Orders��$��16(����#333� $��24q� �� $��2* ��� $
��1.2* � � RowDefinitions �� $��* ��� $��* �.+��� $��Orders��$
��Bold"�$��0��$��0��$��0,0,8,8q�.��&   System.Windows.Controls.DataGrid  -     Name$ dgOrders��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   HeadersVisibility$ Column=�   SelectionMode$ Single=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ OrderID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 1  +System.Windows.Controls.DataGridBoundColumn    Binding  �� *	OrderID+  $ 
CustomerID��$	 100   �� *
CustomerID+  $ 
EmployeeID��$	 100   �� *
EmployeeID+  $ 	OrderDate��$	 140   �� *	OrderDate+�� $��Order Details��$
��Bold"�$��0��$��1��$��	0,8,8,-11q�.��  -   $ dgOrderDetails��$ False��$ False��$ Column=�$ Single=�   $ 	ProductID��$ 80   �� *	ProductID+  $ 	UnitPrice��$	 100   �� *	UnitPrice+  $ Quantity��$ 80   �� *
Quantity+  $ Discount��$ 80   �� *
Discount+�� $��1��$��2��$��	8,0,0,-11q�.+��� $��OrderID��$��12(�$��0,4,0,0q��� -   ! ��Name$! 
txtOrderID��#��[ �� $��
CustomerID��$��12(�$��0,4,0,0q��� -   $! txtOrderCustomerID��#��[ �� $��
EmployeeID��$��12(�$��0,4,0,0q��� -   $! txtOrderEmployeeID��#��[ �� $��	OrderDate��$��12(�$��0,4,0,0q�(  "System.Windows.Controls.DatePicker  -   "  Name$" dpOrderDate��$��0,4,0,4q�$��24���� -   $��Create Order��#��[ �� $
��0,16q��� $��	ProductID��$��12(�$��0,4,0,0q��� -	   $! txtDetailProductID��#��[ �� $��	UnitPrice��$��12(�$��0,4,0,0q��� -
   $! txtDetailUnitPrice��#��[ �� $��Quantity��$��12(�$��0,4,0,0q��� -   $! txtDetailQuantity��#��[ �� $��Discount��$��12(�$��0,4,0,0q��� -   $! txtDetailDiscount��#��[ �� # �� Orientation$# 
Horizontal=�$��Center=�$��0,8,0,0q�.+��� -   $��
Add Detail��#��[ �� -   $��Update Detail��#��[ �� -   $��Delete Detail��#��[ 