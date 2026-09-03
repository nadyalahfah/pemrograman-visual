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
