# Pemrograman Visual

Dokumentasi ini berisi rangkuman materi untuk pertemuan mata kuliah/praktikum Pemrograman Visual

## Pertemuan 1: Pengenalan Pemrograman Visual

### 1.1 Apa itu Pemrograman Visual

Pemrograman visual adalah pendekatan dalam membangun aplikasi di mana sebagian besar proses pembuatan antarmuka (interface) dilakukan secara visual, yaitu dengan menempatkan dan mengatur objek atau komponen secara langsung pada sebuah form melalui antarmuka grafis (drag and drop), bukan dengan menuliskan kode program baris demi baris untuk mengatur tampilan.

Berbeda dengan pemrograman konvensional (tekstual) yang seluruh alur program termasuk tampilan harus ditulis dalam bentuk kode, pemrograman visual memisahkan dua hal:

- **Desain tampilan (interface)**: dibuat secara visual menggunakan komponen yang sudah disediakan oleh IDE (Integrated Development Environment), seperti tombol, label, kotak teks, dan lain-lain.
- **Logika program (behaviour)**: tetap ditulis menggunakan kode program, biasanya berupa respons terhadap suatu kejadian (event) yang terjadi pada komponen tersebut.

### 1.2 Konsep Event-Driven Programming

Pemrograman visual umumnya menganut konsep **event-driven programming** (pemrograman berbasis kejadian). Artinya, program tidak berjalan secara berurutan dari atas ke bawah seperti pemrograman prosedural biasa, melainkan menunggu suatu kejadian (event) terjadi, misalnya:

- Pengguna mengklik tombol (`Click`)
- Pengguna mengetik pada kotak teks (`TextChanged`)
- Form pertama kali ditampilkan (`Load`)

Setiap kejadian tersebut akan memicu (trigger) sebuah blok kode tertentu yang disebut **event handler**. Program akan bereaksi sesuai dengan event apa yang terjadi.

### 1.3 Komponen Utama dalam IDE Pemrograman Visual

Dalam IDE seperti Visual Studio, terdapat beberapa bagian penting yang perlu dipahami:

| Komponen | Fungsi |
|---|---|
| Form | Kanvas atau wadah utama tempat semua komponen antarmuka diletakkan |
| Toolbox | Kumpulan komponen (control) yang dapat ditambahkan ke form, misalnya Label, TextBox, Button |
| Properties Window | Tempat mengatur properti dari setiap komponen, seperti nama, warna, ukuran, teks default, dan lain-lain |
| Solution Explorer | Menampilkan struktur project, termasuk file form dan file kode |
| Code Editor | Tempat menuliskan kode program (event handler) untuk setiap komponen |

### 1.4 Komponen (Control) yang Umum Digunakan

Beberapa komponen dasar yang sering dipakai dalam pemrograman visual, khususnya di VB.NET:

- **Label**: menampilkan teks statis sebagai keterangan atau judul.
- **TextBox**: tempat pengguna memasukkan atau mengedit teks.
- **Button**: tombol yang dapat diklik untuk menjalankan suatu aksi tertentu.
- **Form**: jendela utama aplikasi tempat seluruh komponen diletakkan.

### 1.5 Bahasa dan Tools Pemrograman Visual

Beberapa bahasa dan tools yang mendukung pendekatan pemrograman visual antara lain:

- Visual Basic .NET (VB.NET)
- C# dengan Windows Forms atau WPF
- Delphi
- Java dengan NetBeans GUI Builder

Pada praktikum ini, bahasa yang digunakan adalah **Visual Basic .NET (VB.NET)** dengan platform **Windows Forms Application**.

### 1.6 Kelebihan dan Kekurangan Pemrograman Visual

**Kelebihan:**

- Lebih mudah dipelajari oleh pemula karena tampilan dapat dilihat langsung saat proses desain (WYSIWYG - What You See Is What You Get).
- Proses pembuatan antarmuka lebih cepat karena tinggal drag and drop komponen.
- Kode yang ditulis lebih fokus pada logika program, bukan pada perhitungan tata letak tampilan.

**Kekurangan:**

- Kode yang dihasilkan oleh IDE (seperti file designer) terkadang sulit dipahami jika dilihat langsung.
- Ketergantungan terhadap satu IDE tertentu, sehingga project bisa jadi kurang portable ke platform lain.
- Untuk aplikasi dengan tampilan yang sangat kompleks atau dinamis, pendekatan visual murni terkadang kurang fleksibel dibanding pendekatan berbasis kode penuh.

---

## Pertemuan 2: Studi Kasus Program Biodata Mahasiswa

Pada pertemuan kedua ini, materi diterapkan langsung melalui sebuah studi kasus program sederhana, yaitu **Form Biodata Mahasiswa**, yang dibuat menggunakan Visual Basic .NET (VB.NET). File program disimpan dalam `Form1.vb`.

### 2.1 Deskripsi Program

Program ini merupakan aplikasi Windows Forms sederhana yang berfungsi untuk menginput dan menampilkan biodata mahasiswa, yang terdiri dari:

- Nama
- NIM (Nomor Induk Mahasiswa)
- Komisi/Kelas (disingkat "Kom")

Program menyediakan tiga tombol aksi utama, yaitu untuk menampilkan data, menghapus data pada form, dan keluar dari aplikasi.

### 2.2 Daftar Komponen (Control) yang Digunakan

Berdasarkan kode program pada `Form1.vb`, dapat diketahui komponen-komponen yang digunakan pada form beserta fungsinya:

| Nama Komponen | Jenis Control | Fungsi |
|---|---|---|
| `lblNama` | Label | Menampilkan keterangan/label untuk kolom Nama |
| `lblNim` | Label | Menampilkan keterangan/label untuk kolom NIM |
| `lblKom` | Label | Menampilkan keterangan/label untuk kolom Komisi/Kelas |
| `txtNama` | TextBox | Tempat pengguna menginput nama |
| `txtNim` | TextBox | Tempat pengguna menginput NIM |
| `txtKom` | TextBox | Tempat pengguna menginput komisi/kelas |
| `btnTampilkan` | Button | Menampilkan biodata yang telah diinput melalui MessageBox |
| `btnHapus` | Button | Mengosongkan seluruh isi TextBox |
| `btnKeluar` | Button | Menutup aplikasi |
| `btnSubmit` | Button | Tombol tambahan yang tersedia pada form namun belum memiliki logika (kosong) |

### 2.3 Penjelasan Kode Program (`Form1.vb`)

Berikut adalah penjelasan setiap bagian kode program secara berurutan.

#### a. Deklarasi Class

```vb
Public Class Form1
```

Baris ini mendeklarasikan sebuah class bernama `Form1` yang merepresentasikan tampilan form yang sedang dibuat. Seluruh event handler dari komponen-komponen pada form ini akan diletakkan di dalam class ini.

#### b. Event Handler `Label1_Click` (untuk `lblNama`)

```vb
Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

End Sub
```

Kode ini akan dijalankan ketika label `lblNama` diklik. Pada program ini, blok kodenya masih kosong, artinya belum ada aksi yang terjadi saat label tersebut diklik. Event handler ini kemungkinan terbentuk otomatis oleh IDE saat komponen di-double click pada mode desain.

#### c. Event Handler `btnSubmit_Click`

```vb
Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

End Sub
```

Method ini dimaksudkan untuk menangani event klik pada tombol `btnSubmit`. Namun perlu diperhatikan bahwa method ini **tidak memiliki klausa `Handles btnSubmit.Click`**, sehingga secara teknis method ini tidak terhubung (belum ter-binding) dengan tombol `btnSubmit` pada form, dan isinya pun masih kosong. Artinya, saat tombol ini diklik pada aplikasi, tidak ada aksi apa pun yang akan terjadi.

#### d. Event Handler `Form1_Load`

```vb
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub
```

Event ini akan dipicu secara otomatis satu kali ketika form pertama kali dimuat atau ditampilkan ke layar (sebelum pengguna melakukan interaksi apa pun). Kata kunci `MyBase.Load` menunjukkan bahwa event ini berasal dari class induk (base class) dari `Form1`, yaitu class `Form` bawaan .NET Framework. Blok kode ini biasanya digunakan untuk melakukan inisialisasi awal, misalnya mengatur nilai default pada komponen, namun pada program ini isinya masih kosong.

#### e. Event Handler `TextBox1_TextChanged` (untuk `txtNama`)

```vb
Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

End Sub
```

Event ini akan terpicu setiap kali isi dari `txtNama` mengalami perubahan, misalnya saat pengguna mengetik atau menghapus karakter di dalamnya. Umumnya event ini digunakan untuk melakukan validasi input secara langsung (real time), namun pada program ini belum diberikan logika apa pun.

#### f. Event Handler `Label1_Click_1` (untuk `lblNim`) dan `Label1_Click_2` (untuk `lblKom`)

```vb
Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNim.Click

End Sub

Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblKom.Click

End Sub
```

Kedua method ini serupa dengan `Label1_Click` sebelumnya, yaitu menangani event klik pada label `lblNim` dan `lblKom`. Penamaan `_1` dan `_2` muncul karena IDE secara otomatis menambahkan akhiran angka ketika nama method dasar (`Label1_Click`) sudah digunakan sebelumnya, agar tidak terjadi duplikasi nama method. Kedua blok ini juga masih kosong.

#### g. Event Handler `btnTampilkan_Click`

```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    MessageBox.Show("Halo" & vbCrLf &
                    "Nama : " & txtNama.Text & vbCrLf &
                    "Nim  : " & txtNim.Text & vbCrLf &
                    "Kom  : " & txtKom.Text & vbCrLf &
                    "Selamat Datang di Visual Basic")
End Sub
```

Ini merupakan bagian inti dari program. Method ini akan dijalankan ketika tombol `btnTampilkan` diklik. Penjelasan kodenya:

- `MessageBox.Show(...)` digunakan untuk menampilkan sebuah kotak dialog (pop up) yang berisi pesan kepada pengguna.
- Tanda `&` digunakan untuk menggabungkan (concatenate) beberapa string menjadi satu kalimat utuh.
- `vbCrLf` adalah konstanta yang merepresentasikan karakter ganti baris (carriage return + line feed), sehingga teks pada kotak dialog akan tertata rapi dalam beberapa baris, bukan menjadi satu baris panjang.
- `txtNama.Text`, `txtNim.Text`, dan `txtKom.Text` digunakan untuk mengambil nilai teks yang sedang diinput pengguna pada masing-masing TextBox.

Secara keseluruhan, method ini berfungsi untuk mengambil data yang sudah diinput pengguna pada TextBox, kemudian menampilkannya dalam bentuk pesan sapaan melalui kotak dialog.

#### h. Event Handler `btnHapus_Click`

```vb
Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    txtNama.Clear()
    txtNim.Clear()
    txtKom.Clear()
End Sub
```

Method ini dijalankan saat tombol `btnHapus` diklik. Fungsi `Clear()` digunakan untuk mengosongkan kembali isi dari TextBox `txtNama`, `txtNim`, dan `txtKom`, sehingga form kembali kosong dan siap digunakan untuk menginput data yang baru.

#### i. Event Handler `btnKeluar_Click`

```vb
Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
    Me.Close()
End Sub
```

Method ini dijalankan saat tombol `btnKeluar` diklik. `Me` merujuk pada form yang sedang aktif (dalam hal ini `Form1` itu sendiri), sedangkan `Close()` adalah method bawaan untuk menutup form tersebut, yang secara otomatis akan mengakhiri aplikasi jika `Form1` merupakan form utama dari project.

#### j. Penutup Class

```vb
End Class
```

Baris ini menandai akhir dari deklarasi class `Form1`.

### 2.4 Alur Kerja Program Secara Keseluruhan

1. Aplikasi dijalankan, event `Form1_Load` terpicu untuk pertama kali (namun belum ada aksi karena masih kosong).
2. Pengguna mengetikkan Nama, NIM, dan Kom pada masing-masing TextBox.
3. Jika pengguna menekan tombol **Tampilkan**, maka data yang telah diinput akan ditampilkan dalam sebuah kotak dialog (MessageBox) berupa pesan sapaan.
4. Jika pengguna menekan tombol **Hapus**, maka seluruh isi TextBox akan dikosongkan kembali.
5. Jika pengguna menekan tombol **Keluar**, maka aplikasi akan ditutup.

## Pertemuan 3: Operator dan Struktur Kendali

Pada pertemuan ketiga, materi yang dipelajari adalah penggunaan operator dan struktur kendali pada Visual Basic .NET (VB.NET). Materi kemudian diterapkan pada sebuah program sederhana yang menerima input nilai ujian dan menampilkan gambar berdasarkan nilai yang dimasukkan.

Selain penggunaan `If`, `ElseIf`, dan `Else`, pada pertemuan ini juga dipelajari cara melakukan validasi input menggunakan `TryParse` serta membatasi karakter yang dapat dimasukkan ke dalam `TextBox` menggunakan event `KeyPress`.

### 3.1 Deskripsi Program

Program pada pertemuan ini digunakan untuk memasukkan nilai ujian dengan rentang 0 sampai 100. Setelah tombol input ditekan, program akan mengecek apakah nilai yang dimasukkan berupa angka dan apakah nilainya berada dalam rentang yang diperbolehkan.

Setelah nilai berhasil divalidasi, program akan menampilkan gambar yang berbeda berdasarkan nilai tersebut:

| Nilai    | Gambar  |
| -------- | ------- |
| 0 - 50   | `1.jpg` |
| 51 - 75  | `2.jpg` |
| 76 - 100 | `3.jpg` |

Gambar disimpan di dalam folder `Assets` pada project.

### 3.2 Struktur Kendali `If`, `ElseIf`, dan `Else`

Struktur `If` digunakan untuk membuat percabangan berdasarkan kondisi tertentu. Pada program ini, percabangan digunakan untuk menentukan gambar yang akan ditampilkan berdasarkan nilai ujian.

```vb
If nilaiUjian <= 50 Then
    picImage.Image = Image.FromFile("Assets\1.jpg")
ElseIf nilaiUjian <= 75 Then
    picImage.Image = Image.FromFile("Assets\2.jpg")
Else
    picImage.Image = Image.FromFile("Assets\3.jpg")
End If
```

Jika nilai kurang dari atau sama dengan 50, maka gambar `1.jpg` ditampilkan. Jika nilai lebih dari 50 tetapi masih kurang dari atau sama dengan 75, maka `2.jpg` ditampilkan. Selain kondisi tersebut, berarti nilai berada di atas 75 sehingga `3.jpg` ditampilkan.

### 3.3 Validasi Input dengan `Integer.TryParse`

Input dari `TextBox` pada dasarnya berupa data bertipe teks. Karena nilai ujian akan digunakan sebagai `Integer`, maka input perlu dikonversi terlebih dahulu.

Pada program digunakan:

```vb
Dim nilaiUjian As Integer

If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
    MessageBox.Show("Masukkan dalam bentuk angka")
    txtNilai.Focus()
    Return
End If
```

`Integer.TryParse()` digunakan untuk mencoba mengubah isi `txtNilai` menjadi tipe data `Integer`.

Jika input bukan angka, hasil `TryParse` adalah `False`. Karena menggunakan `Not`, kondisi `If` menjadi benar sehingga program menampilkan pesan **"Masukkan dalam bentuk angka"**.

`txtNilai.Focus()` digunakan agar kursor kembali ke `TextBox` nilai sehingga pengguna dapat memperbaiki input. Sedangkan `Return` digunakan untuk menghentikan proses agar program tidak melanjutkan ke bagian berikutnya.

### 3.4 Membatasi Nilai dengan Operator Logika

Setelah memastikan input berupa angka, program juga membatasi nilai agar hanya menerima angka 0 sampai 100.

```vb
If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
    MessageBox.Show("Masukkan nilai 0 - 100")
    txtNilai.Focus()
    Return
End If
```

Pada kondisi tersebut digunakan operator `OrElse`. Artinya, program akan masuk ke dalam `If` jika nilai kurang dari 0 **atau** nilai lebih dari 100.

Jadi, walaupun input sudah berupa angka, nilai seperti `-10` atau `150` tetap ditolak karena tidak sesuai dengan rentang nilai yang ditentukan.

### 3.5 Event `KeyPress`

Selain melakukan validasi ketika tombol Input ditekan, input juga dibatasi sejak pengguna mengetik di `TextBox`.

Event yang digunakan adalah `KeyPress`:

```vb
Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress

    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If

End Sub
```

`KeyPress` merupakan event yang terjadi ketika pengguna menekan sebuah tombol keyboard pada `TextBox`.

Pada program ini, event tersebut digunakan agar `txtNilai` hanya dapat menerima karakter yang sesuai dengan kebutuhan input nilai.

### 3.6 Penggunaan `KeyChar`

Pada event `KeyPress` terdapat `e.KeyChar`.

`KeyChar` digunakan untuk mendapatkan karakter yang sedang ditekan oleh pengguna. Karakter tersebut kemudian dapat diperiksa menggunakan fungsi dari `Char`.

Contohnya:

```vb
Char.IsDigit(e.KeyChar)
```

Kode tersebut digunakan untuk mengecek apakah karakter yang ditekan merupakan angka.

Pada program digunakan:

```vb
If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
    e.Handled = True
End If
```

Artinya, jika karakter yang ditekan bukan karakter kontrol dan bukan angka, maka input tersebut akan ditolak.

`e.Handled = True` digunakan untuk memberitahu program bahwa input tersebut sudah ditangani sehingga karakter tidak dimasukkan ke dalam `TextBox`.

Karakter kontrol tetap diperbolehkan karena pengguna masih perlu melakukan hal seperti menghapus karakter menggunakan Backspace.

### 3.7 `IsDigit` dan `IsLetter`

Pada validasi menggunakan `KeyPress`, fungsi `Char` dapat digunakan untuk memeriksa jenis karakter.

Beberapa fungsi yang dipelajari antara lain:

* `Char.IsDigit()` → mengecek apakah karakter merupakan angka.
* `Char.IsLetter()` → mengecek apakah karakter merupakan huruf.
* `Char.IsControl()` → mengecek apakah karakter merupakan karakter kontrol seperti Backspace.

Contoh jika sebuah `TextBox` hanya ingin menerima huruf:

```vb
If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
    e.Handled = True
End If
```

Dengan cara tersebut, karakter angka dapat ditolak dan `TextBox` hanya menerima huruf serta karakter kontrol.

Jadi, penggunaan `IsDigit` atau `IsLetter` disesuaikan dengan jenis data yang ingin dimasukkan ke dalam `TextBox`.

### 3.8 Pengaturan Gambar pada `PictureBox`

Program juga menggunakan `PictureBox` dengan nama `picImage` untuk menampilkan gambar berdasarkan nilai yang dimasukkan.

Gambar yang digunakan berada di folder:

```text
Assets
├── 1.jpg
├── 2.jpg
└── 3.jpg
```

Pada pengaturan `PictureBox`, gambar dapat dibuat menyesuaikan ukuran area menggunakan properti `SizeMode`.

Salah satu pengaturan yang digunakan adalah:

```text
SizeMode = Zoom
```

`Zoom` membuat gambar menyesuaikan ukuran `PictureBox` dengan tetap mempertahankan perbandingan ukuran gambar, sehingga gambar tidak terlihat terlalu melebar atau gepeng.

### 3.9 Pengaturan `Copy to Output Directory`

File gambar yang digunakan program perlu tersedia ketika aplikasi dijalankan. Oleh karena itu, file gambar pada folder `Assets` dapat diatur agar ikut disalin ke folder output project.

Pada Properties file gambar dapat digunakan:

```text
Copy to Output Directory = Copy if newer
```

`Copy if newer` berarti file akan disalin ke folder output jika file tersebut belum ada atau versi file di project lebih baru daripada file yang sudah ada di folder output.

Pengaturan ini membantu memastikan file gambar seperti `1.jpg`, `2.jpg`, dan `3.jpg` tetap tersedia ketika program dijalankan.

### 3.10 Alur Kerja Program

Alur program pada pertemuan ketiga adalah:

1. Pengguna memasukkan nilai pada `txtNilai`.
2. Event `KeyPress` memeriksa karakter yang diketik.
3. Karakter selain angka dan karakter kontrol akan ditolak.
4. Ketika tombol Input ditekan, `Integer.TryParse()` memeriksa apakah input dapat diubah menjadi angka.
5. Jika bukan angka, program menampilkan pesan kesalahan.
6. Jika berupa angka, program mengecek apakah nilai berada pada rentang 0 sampai 100.
7. Jika nilai tidak sesuai, program menampilkan pesan kesalahan.
8. Jika nilai valid, struktur `If`, `ElseIf`, dan `Else` menentukan gambar yang akan ditampilkan.
9. Gambar ditampilkan melalui `PictureBox`.

### 3.11 Kesimpulan

Pada pertemuan ketiga, selain mempelajari operator dan struktur kendali, dipelajari juga cara membuat input menjadi lebih terkontrol. `TryParse` digunakan untuk memastikan data dapat diproses sebagai angka, sedangkan `KeyPress`, `KeyChar`, `IsDigit`, dan `IsLetter` dapat digunakan untuk membatasi karakter yang boleh dimasukkan pengguna.

Penggunaan `If`, `ElseIf`, dan `Else` kemudian digunakan untuk menentukan hasil berdasarkan nilai yang dimasukkan. Pada bagian gambar, `PictureBox` digunakan untuk menampilkan hasil dan pengaturan `Zoom` digunakan agar gambar menyesuaikan area tampilannya.

## Tugas 1 - Aplikasi Login dan Perhitungan Pajak

Project ini merupakan tugas Pemrograman Visual menggunakan **VB.NET Windows Forms** yang terdiri dari dua form, yaitu `FrmLogin` dan `FrmPajak`.

### Materi yang Digunakan

- Windows Forms dan komponen visual: `Label`, `TextBox`, `ComboBox`, `PictureBox`, dan `Button`
- Event `Click`, `KeyPress`, dan `SelectedIndexChanged`
- Validasi input menggunakan `Char.IsLetter`, `Char.IsDigit`, `Decimal.TryParse`
- Percabangan `If...Then...ElseIf...Else`
- Perpindahan antar form menggunakan `Show()`, `Hide()`, dan `Close()`
- Mengosongkan input menggunakan `Clear()`
- Mengembalikan fokus menggunakan `Focus()`
- Menampilkan pesan menggunakan `MessageBox.Show()`

### Form Login

`FrmLogin` digunakan untuk login berdasarkan **role, nama, dan NIM**. Role yang tersedia adalah `Staff` dan `Manager`. Gambar pada `PictureBox` berubah sesuai role yang dipilih.

Data login:
- Staff: `Nadya` - `241712051`
- Manager: `Mingyu` - `241712000`

Input nama dibatasi menggunakan `KeyPress`, sedangkan proses login memeriksa kesesuaian role, nama, dan NIM.

### Form Pajak

`FrmPajak` digunakan untuk menghitung pajak berdasarkan pendapatan.

| Pendapatan | Pajak |
|---|---:|
| ≤ Rp5.000.000 | 0% |
| ≤ Rp30.000.000 | 10% |
| ≤ Rp100.000.000 | 20% |
| > Rp100.000.000 | 30% |

Rumus:

```text
Pajak = Pendapatan × Persentase Pajak
```

## Pertemuan 4: Struktur Perulangan

### Tujuan
Mempelajari penggunaan struktur perulangan `For` pada VB.NET untuk menampilkan data berdasarkan nilai awal dan nilai akhir

### Materi
- Perulangan `For`
- `Step -1` untuk perulangan menurun
- `Integer.TryParse()` untuk validasi input angka
- Event `KeyPress` untuk membatasi input
- `ListBox` untuk menampilkan hasil
- `If...Else` untuk menentukan arah perulangan

### Komponen
- `txtNilaiAwal` → input nilai awal
- `txtNilaiAkhir` → input nilai akhir
- `btnInput` → menjalankan perulangan
- `lstHasil` → menampilkan hasil

### Validasi Input
Input diperiksa menggunakan `Integer.TryParse()` agar hanya data berupa angka yang dapat diproses

```vb
If Not Integer.TryParse(txtNilaiAwal.Text, nilaiAwal) Then
    MessageBox.Show("Masukkan angka yang valid!")
    txtNilaiAwal.Focus()
    Return
End If
```

Event `KeyPress` juga digunakan agar TextBox hanya menerima angka.

```vb
If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
    e.Handled = True
End If
```

### Perulangan

Jika nilai awal lebih kecil dari nilai akhir, program menggunakan perulangan biasa:

```vb
For i As Integer = nilaiAwal To nilaiAkhir
    lstHasil.Items.Add(i)
Next
```

Jika nilai awal lebih besar, digunakan `Step -1`:

```vb
For i As Integer = nilaiAwal To nilaiAkhir Step -1
    lstHasil.Items.Add(i)
Next
```

Sebelum menampilkan hasil baru, data pada `ListBox` dikosongkan menggunakan:

```vb
lstHasil.Items.Clear()
```

### Alur Program

1. Masukkan nilai awal dan nilai akhir
2. Program melakukan validasi input
3. Program menentukan apakah perulangan naik atau turun
4. Perulangan `For` dijalankan
5. Hasil ditampilkan pada `ListBox`.

### Contoh

Input `1` sampai `5` menghasilkan:

```text
1
2
3
4
5
```

Input `5` sampai `1` menghasilkan:

```text
5
4
3
2
1
```
