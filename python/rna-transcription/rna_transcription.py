def to_rna(dna):
    intab = "GCTA"
    outtab = "CGAU"
    for char in dna:
        if char not in intab:
            return ''
    return dna.translate(str.maketrans(intab, outtab))