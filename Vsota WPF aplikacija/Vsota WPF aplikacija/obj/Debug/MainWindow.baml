   M S B A M L   `   `   `  ����O  KVsota WPF aplikacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Vsota_WPF_aplikacijaVsota_WPF_aplikacija  5   	   %    Vsota_WPF_aplikacija.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Vsota_WPF_aplikacija     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblPrvoŠtevilo��5
      $��Prvo število:��6(   $
��Left=�6@   $��	42,51,0,0q�6[   $	��Top=�6n   �� 5   
   -   5        $ lblDrugoŠtevilo��5      $��Drugo število:��6)   $
��Left=�6B   $��	42,92,0,0q�6]   $	��Top=�6p   �� 5   
   -   5        $ lblRezultat��5      $��	Rezultat:��6%   $
��Left=�69   $��
42,143,0,0q�6T   $	��Top=�6h   �� 5   
   -   5         ��Name$ txtPrvoŠtevilo��5      $
��Left=�6*   $��
146,59,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $ txtDrugoŠtevilo��5      $
��Left=�6+   $��
146,96,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   �� 5   
   -   5        $ txtRezultat��5      $
��Left=�6'   $��146,147,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�    �� IsReadOnlyCaretVisible . 6�   �� 5   
   -   5         ��Name$ btnIzračunaj��5      $��
Izračunaj��6'   $
��Left=�6;   $��
50,217,0,0q�6V   $	��Top=�6j   6�   �� 5   
   -   5        $ btnPočisti��5      $��Počisti��6%   $
��Left=�67   $��146,217,0,0q�6R   $	��Top=�6g   6   �� 5   
   $��	Operacije��6   $��306,45,376,269q�6&   	� 5   
   -	   5         	�Name$ radSeš��5      $��Seštevanje��6&   $
��Left=�6;   $��
315,68,0,0q�6V   $	��Top=�6j    d� 	IsChecked$
 TrueY�6�   	� 5   
   -
   5        $ radOdš��5      $��Odštevanje��6&   $
��Left=�6;   $��
315,88,0,0q�6V   $	��Top=�6j   6�   	� 5   
   -   5        $ radMno��5      $��	Množenje��6&   $
��Left=�69   $��315,108,0,0q�6T   $	��Top=�6i   6�   	� 5   
   -   5        $ radDel��5      $��Deljenje��6&   $
��Left=�69   $��315,128,0,0q�6T   $	��Top=�6i   6�   5      5      