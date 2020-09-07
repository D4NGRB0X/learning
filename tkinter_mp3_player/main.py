from tkinter import *
from tkinter import filedialog
from tkinter import ttk
import pygame
from mutagen.mp3 import MP3
import time

root = Tk()

root.title('MP3 Player')
root.geometry('650x350')

pygame.mixer.init()


def add_song_to_playlist():
    song = filedialog.askopenfilename(
        initialdir="C:/Users/Thomas/Music/",
        title="Choose a Song",
        filetypes=(("mp3 Files", "*.mp3"),)
    )
    song = song.replace("C:/Users/Thomas/Music/", "")
    playlist_box.insert(END, song)


def add_multiple_songs_to_playlist():
    songs = filedialog.askopenfilenames(
        initialdir="C:/Users/Thomas/Music/",
        title="Choose a Song",
        filetypes=(("mp3 Files", "*.mp3"),)
    )
    for song in songs:
        song = song.replace("C:/Users/Thomas/Music/", "")
        playlist_box.insert(END, song)


def remove_song_from_playlist():
    playlist_box.delete(ANCHOR)


def remove_songs_from_playlist():
    playlist_box.delete(0, ANCHOR)


def play_time():
    current_time = pygame.mixer.music.get_pos()/1000
    elapsed_time = time.strftime('%M:%S', time.gmtime(current_time))

    song = playlist_box.get(ACTIVE)
    song = f"C:/Users/Thomas/Music/{song}"

    song_length = time.strftime('%M:%S', time.gmtime(MP3(song).info.length))

    if current_time >= 1:
        status_bar.config(text=f'Elapsed Time: {elapsed_time} / {song_length}')

    status_bar.after(1000, play_time)


def play():
    song = playlist_box.get(ACTIVE)
    song = f"C:/Users/Thomas/Music/{song}"

    pygame.mixer.music.load(song)
    pygame.mixer.music.play(loops=0)

    play_time()


def stop():
    pygame.mixer.music.stop()
    playlist_box.selection_clear(ACTIVE)


paused: bool = False


def pause(is_paused) -> bool:
    global paused
    paused = is_paused

    if is_paused:
        pygame.mixer.music.unpause()
        paused = False
    else:
        pygame.mixer.music.pause()
        paused = True


def back():
    prev_song = playlist_box.curselection()
    prev_song = prev_song[0] - 1

    song = f"C:/Users/Thomas/Music/{playlist_box.get(prev_song)}"

    pygame.mixer.music.load(song)
    pygame.mixer.music.play(loops=0)

    playlist_box.selection_clear(0, END)
    playlist_box.activate(prev_song)
    playlist_box.select_set(prev_song, last=None)


def forward():
    next_song = playlist_box.curselection()
    next_song = next_song[0] + 1
    
    #  song = playlist_box.get(next_song)
    song = f"C:/Users/Thomas/Music/{playlist_box.get(next_song)}"
    
    pygame.mixer.music.load(song)
    pygame.mixer.music.play(loops=0)
    
    playlist_box.selection_clear(0, END)
    playlist_box.activate(next_song)
    playlist_box.select_set(next_song, last=None)


def set_volume(*args):
    pygame.mixer.music.set_volume(volume_slider.get())


main_frame = Frame(root)
main_frame.pack(pady=20)

control_frame = Frame(main_frame)
control_frame.grid(row=1, column=0, pady=20)

playlist_box = Listbox(main_frame, bg="black", fg="green", width=80, selectbackground="green")
playlist_box.grid(row=0, column=0)

volume_frame = LabelFrame(main_frame, text="Volume")
volume_frame.grid(row=0, column=1, padx=25)

volume_slider = ttk.Scale(volume_frame, from_=0, to=1, orient=VERTICAL, length=125, value=.5, command=set_volume)
volume_slider.pack(pady=10)

back_button_img = PhotoImage(file='img/back50.png')
forward_button_img = PhotoImage(file='img/forward50.png')
play_button_img = PhotoImage(file='img/play50.png')
pause_button_img = PhotoImage(file='img/pause50.png')
stop_button_img = PhotoImage(file='img/stop50.png')

back_button = Button(control_frame, image=back_button_img, borderwidth=0, command=back)
forward_button = Button(control_frame, image=forward_button_img, borderwidth=0, command=forward)
play_button = Button(control_frame, image=play_button_img, borderwidth=0, command=play)
pause_button = Button(control_frame, image=pause_button_img, borderwidth=0, command=lambda: pause(paused))
stop_button = Button(control_frame, image=stop_button_img, borderwidth=0, command=stop)

buttons = [back_button, forward_button, play_button, pause_button, stop_button]
for index, button in enumerate(buttons):
    button.grid(row=0, column=index, padx=10)

my_menu = Menu(root)
root.config(menu=my_menu)

add_song_menu = Menu(my_menu, tearoff=0)

my_menu.add_cascade(label="Add Songs", menu=add_song_menu)
add_song_menu.add_command(label="Add Song To Playlist", command=add_song_to_playlist)
add_song_menu.add_command(label="Add Songs To Playlist", command=add_multiple_songs_to_playlist)

remove_song_menu = Menu(my_menu, tearoff=0)
my_menu.add_cascade(label="Remove Songs", menu=remove_song_menu)
remove_song_menu.add_command(label="Remove Song From Playlist", command=remove_song_from_playlist)
remove_song_menu.add_command(label="Remove Songs From Playlist", command=remove_songs_from_playlist)

status_bar = Label(root, text=" ", bd=1, relief=GROOVE, anchor=E)
status_bar.pack(fill=X,side=BOTTOM, ipady=2)

my_label = Label(root, text="")
my_label.pack(pady=10)

root.mainloop()
