﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test.components
{
    /// <summary>
    /// Выполните шаги 1a или 1b, а затем 2, чтобы использовать этот пользовательский элемент управления в файле XAML.
    ///
    /// Шаг 1a. Использование пользовательского элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:test.components"
    ///
    ///
    /// Шаг 1б. Использование пользовательского элемента управления в файле XAML, существующем в другом проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:test.components;assembly=test.components"
    ///
    /// Потребуется также добавить ссылку из проекта, в котором находится файл XAML,
    /// на данный проект и пересобрать во избежание ошибок компиляции:
    ///
    ///     Щелкните правой кнопкой мыши нужный проект в обозревателе решений и выберите
    ///     "Добавить ссылку"->"Проекты"->[Поиск и выбор проекта]
    ///
    ///
    /// Шаг 2)
    /// Теперь можно использовать элемент управления в файле XAML.
    ///
    ///     <MyNamespace:CustomInput/>
    ///
    /// </summary>
    public class CustomInput : TextBox
    {
        static CustomInput()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomInput), new FrameworkPropertyMetadata(typeof(CustomInput)));
        }

        public static readonly DependencyProperty PlaceholderProperty =
        DependencyProperty.Register(
           name: "Placeholder",
           propertyType: typeof(string),
           ownerType: typeof(CustomInput),
           typeMetadata: new FrameworkPropertyMetadata(
               defaultValue: "Default value",
               flags: FrameworkPropertyMetadataOptions.AffectsMeasure),
           validateValueCallback: new ValidateValueCallback(IsValidReading));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public static bool IsValidReading(object value)
        {
            string val = (string)value;
            return val.All(ch => ch != '.');
        }
    }
}