﻿using SOsimulatorWPF.Components;
using SOsimulatorWPF.Escalonador;
using SOsimulatorWPF.Models;
using System;
using System.Threading;
using System.Windows;

namespace SOsimulatorWPF.Views
{
    /// <summary>
    /// Interaction logic for PreemptivoWindow.xaml
    /// </summary>
    public partial class PreemptivoWindow : Window
    {
        private RoundRobin Algoritmo;
        private Thread thread;

        public PreemptivoWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            RamListView.ItemsSource = RAM.Processos;
            MmuListView.ItemsSource = MMU.Processos;
            CpuListView.ItemsSource = CPU.Processo;

            Algoritmo = new RoundRobin();

            thread = new Thread(Algoritmo.StartAlgoritmo);
            thread.Start();
        }

        private void Chrome_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Google Chrome";
                app.Tamanho = 128;
                app.TempoExecucao = 5;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Code_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Visual Code";
                app.Tamanho = 128;
                app.TempoExecucao = 5;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Paint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Paint";
                app.TempoExecucao = 5;
                app.Tamanho = 60;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Excel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Excel";
                app.TempoExecucao = 5;
                app.Tamanho = 80;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Firefox_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Firefox";
                app.TempoExecucao = 5;
                app.Tamanho = 100;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Photoshop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Photoshop";
                app.TempoExecucao = 5;
                app.Tamanho = 90;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Paciencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Paciência";
                app.TempoExecucao = 5;
                app.Tamanho = 50;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Notepad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Notepad";
                app.Tamanho = 30;
                app.TempoExecucao = 5;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            thread.Abort();
            //CPU.RemoverProcesso();
            //MMU.Clear();
            //RAM.Clear();
            this.Close();
        }
    }
}
